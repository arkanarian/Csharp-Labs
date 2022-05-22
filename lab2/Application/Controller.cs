using System;
using System.Linq;
using System.Drawing;
using System.Reflection;
using DomainModel;

namespace MVC
{
    public class Controller
    {
        private Model appModel = null;
        private DomainModel.FileInteractions fileInteractions = null;
        private View view = null;
        public String PluginPath = "D:\\OOP\\lab2_2\\Plugin\\bin\\Debug\\net5.0\\Plugin.dll";
        private bool CheckLastFlag { get; set; }
        
        public Controller(Model appModel, DomainModel.FileInteractions fileInteractions, View view)
        {
            this.appModel = appModel;
            this.fileInteractions = fileInteractions;
            this.view = view;
        }

        public void Initialize()
        {
            appModel.Initialize();
        }

        public void LoadPlugin()
        {
            Assembly a = Assembly.LoadFrom(PluginPath);

            Type[] type = a.GetTypes();
            Type ourtype = typeof(Figure);

            foreach (var t in type)
            {
                if (t.IsSubclassOf(ourtype))
                {
                    fileInteractions.TypeList.Add(t);
                }
            }
        }

        public void NewFile()
        {
            appModel.Initialize();
            fileInteractions.Elements.Clear();
            view.Update();
        }

        public void MouseDown(int x, int y)
        {
            appModel.IsMouseDown = true;

            if (appModel.CurrentElement != null && appModel.IsCurrentElementActive == false)
            {
                appModel.IsCurrentElementActive = true;

                appModel.CurrentElement.X1 = x;
                appModel.CurrentElement.Y1 = y;
                appModel.CurrentElement.X2 = x;
                appModel.CurrentElement.Y2 = y;
            }

            view.Update();
        }

        public void MouseMove(int x, int y)
        {
            appModel.CursorPositionX = x;
            appModel.CursorPositionY = y;

            if (appModel.CurrentElement != null && appModel.IsCurrentElementActive == true)
            {
                if (appModel.IsFillActive == true)
                    appModel.CurrentElement.IsFillNull = false;
                appModel.CurrentElement.UpdateOnMouseMove(x, y);
                //appModel.CurrentElement.Draw(domainModel.Graphics, pen);
            }

        }

        public void MouseUp()
        {
            appModel.IsMouseDown = false;

            // If we were drawing with some tool - let's save it on the picture
            if (appModel.CurrentElement != null && appModel.IsCurrentElementActive == true)
            {
                appModel.IsCurrentElementActive = false;

                foreach (var element in fileInteractions.Elements)
                {
                    if (element.IsLastElement == true)
                    {
                        CheckLastFlag = true;
                        continue;
                    }

                    if(CheckLastFlag == true)
                    {
                        fileInteractions.Elements.RemoveRange(fileInteractions.Elements.IndexOf(element), fileInteractions.Elements.Count - fileInteractions.Elements.IndexOf(element));
                        break;
                    }
                }

                CheckLastFlag = false;
                appModel.CurrentElement.BorderColorName = appModel.CurrentElement.BorderColor.Name;
                appModel.CurrentElement.FillColorName = appModel.CurrentElement.FillColor.Name;
                fileInteractions.Elements.Add(appModel.CurrentElement);
                fileInteractions.CheckLastElement();
//                domainModel.DrawElements();
                view.Update();

                // Create new element
                var type = appModel.CurrentElement.GetType();
                appModel.CurrentElement = null;

                appModel.CurrentElement = (Figure)Activator.CreateInstance(type);
                appModel.CurrentElement.X1 = appModel.CursorPositionX;
                appModel.CurrentElement.Y1 = appModel.CursorPositionY;
                appModel.CurrentElement.BorderColor = appModel.CurrentDrawingColor;
                appModel.CurrentElement.FillColor = appModel.CurrentFillColor;
                appModel.CurrentElement.Width = appModel.CurrentWidth;
                appModel.CurrentElement.TypeOfElement = type.ToString();

            }

            view.Update();
        }

        public void SaveFile(String fileName)
        {
            fileInteractions.Serialize(fileInteractions.Elements, fileName);
        }

        public void OpenFile(String fileName)
        {
            appModel.Initialize();
            fileInteractions.Elements.Clear();

            fileInteractions.Elements = fileInteractions.Deserialize(fileName);
            view.Update();
        }

        public void Undo()
        {
            if (fileInteractions.Elements.Count != 0)
            {
                var firstElement = fileInteractions.Elements.First();

                Pen pen = new Pen(Color.White);

                foreach (var element in fileInteractions.Elements)
                {
                    pen.Width = element.Width;

                    if (element.IsLastElement == true)
                    {
                        if (element.Equals(firstElement))
                        {
                            element.IsErased = true;
                            element.Draw(fileInteractions.Graphics, pen);
                            return;
                        }

                        else
                        {
                            fileInteractions.Elements[fileInteractions.Elements.IndexOf(element) - 1].IsLastElement = true;
                            element.IsLastElement = false;

                            element.IsErased = true;
                            element.Draw(fileInteractions.Graphics, pen);

                            //return;
                            break;
                        }
                    }
                }
            }
            view.Update();
        }   

        public void Redo()
        {
            if (fileInteractions.Elements.Count != 0)
            {
                var firstElement = fileInteractions.Elements.First();
                var lastElement = fileInteractions.Elements.Last();

                Pen pen = new Pen(Color.White);

                foreach (var element in fileInteractions.Elements)
                {
                    pen.Color = element.BorderColor;
                    pen.Width = element.Width;

                    if (element.IsLastElement == true)
                    {
                        if (element.Equals(firstElement) && element.IsErased == true)
                        {
                            element.IsErased = false;
                            element.Draw(fileInteractions.Graphics, pen);

                            element.IsLastElement = false;
                            fileInteractions.Elements[fileInteractions.Elements.IndexOf(element) + 1].IsLastElement = true;

                            return;
                        }

                        else if (element.Equals(lastElement))
                        {
                            element.IsErased = false;
                            element.Draw(fileInteractions.Graphics, pen);

                            return;
                        }

                        else
                        {
                            element.IsErased = false;
                            element.Draw(fileInteractions.Graphics, pen);

                            element.IsLastElement = false;
                            var lastel = fileInteractions.Elements[fileInteractions.Elements.IndexOf(element) + 1];
                            lastel.IsLastElement = true;

                            pen.Color = element.BorderColor;
                            pen.Width = element.Width;
                            lastel.IsErased = false;
                            lastel.Draw(fileInteractions.Graphics, pen);
                            break;
                        }
                    }
                }
            }
            view.Update();
        }

        public void CreateNewElement(string newElement)
        {
            foreach (var type in fileInteractions.TypeList)
            {
                if(newElement == type.Name)
                {
                    var element = (Figure)Activator.CreateInstance(type);
                    element.X1 = appModel.CursorPositionX;
                    element.Y1 = appModel.CursorPositionY;
                    element.TypeOfElement = element.GetType().ToString();
                    element.BorderColor = appModel.CurrentDrawingColor;
                    element.FillColor = appModel.CurrentFillColor;
                    element.Width = appModel.CurrentWidth;
                    appModel.CurrentElement = element;
                    break;
                }
            }
        }

        public void DrawByCoordinates(string newElement, int x1, int y1, int x2, int y2)
        {
            foreach (var type in fileInteractions.TypeList)
            {
                if (newElement == type.Name)
                {
                    var element = (Figure)Activator.CreateInstance(type);
                    element.X1 = x1;
                    element.Y1 = y1;
                    element.TypeOfElement = element.GetType().ToString();
                    element.X2 = x2;
                    element.Y2 = y2;
                    element.BorderColor = appModel.CurrentDrawingColor;

                    if (appModel.IsFillActive == true)
                        element.IsFillNull = false;

                    element.FillColor = appModel.CurrentFillColor;
                    element.Width = appModel.CurrentWidth;

                    fileInteractions.Elements.Add(element);
                    fileInteractions.CheckLastElement();
//                    domainModel.DrawElements();
                    view.Update();
                    break;
                }
            }
        }

        public void SetMainColor(string color)
        {
            appModel.CurrentDrawingColor = Color.FromName(color); 
        }

        public void SetFillColor(string backgroudcolor)
        {
            if(backgroudcolor != "Null")
            {
                appModel.IsFillActive = true;
                appModel.CurrentFillColor = Color.FromName(backgroudcolor);
            }

            else
                appModel.IsFillActive = false;
        }

        public void SetWidth(float width)
        {
            appModel.CurrentWidth = width;
        }
    }
}
