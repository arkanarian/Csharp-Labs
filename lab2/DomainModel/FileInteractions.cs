using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace DomainModel
{
    public class FileInteractions
    {
        public List<Figure> Elements { get; set; }
        public List<Type> TypeList { get; set; } 

        public Graphics Graphics { get; set; }

        public void Initialize(Graphics graphics)
        {
            Elements = new List<Figure>();
            this.Graphics = graphics;

            Type ourtype = typeof(Figure);
            IEnumerable<Type> Types = Assembly.GetAssembly(ourtype).GetTypes().Where(type => type.IsSubclassOf(ourtype));

            TypeList = Types.ToList();
        }

        public void Serialize(List<Figure> elements, String fileName)
        {
            var jsonString = JsonSerializer.Serialize((List<Figure>)elements);
            File.WriteAllText(fileName, jsonString);
        }

        public List<Figure> Deserialize(String fileName)
        {
            var newjsonliststring = File.ReadAllText(fileName);
            var newElementList = JsonSerializer.Deserialize<List<Figure>>(newjsonliststring);
            List<Figure> elementList = new List<Figure>();

            foreach (var element in newElementList)
            {
                foreach (var type in TypeList)
                {
                    if(element.TypeOfElement == type.ToString())
                    {
                        var newelement = (Figure)Activator.CreateInstance(type);
                        newelement.X1 = element.X1;
                        newelement.X2 = element.X2;
                        newelement.Y1 = element.Y1;
                        newelement.Y2 = element.Y2;
                        newelement.BorderColor = Color.FromName(element.BorderColorName);
                        newelement.FillColor = Color.FromName(element.FillColorName);
                        newelement.Width = element.Width;
                        newelement.TypeOfElement = element.TypeOfElement;
                        newelement.IsErased = element.IsErased;
                        newelement.IsFillNull = element.IsFillNull;
                        newelement.IsLastElement = element.IsLastElement;

                        elementList.Add(newelement);
                        break;
                    }
                }
            }

            newElementList.Clear();

            return elementList;
        }

        public void DrawElements()
        {
            Pen pen = new Pen(Color.Black);

            foreach (Figure element in Elements)
            {
                pen.Color = element.BorderColor;
                pen.Width = element.Width;

                if (element.IsErased == false)
                {
                    if (element.IsLastElement == false)
                        element.Draw(this.Graphics, pen);

                    else
                    {
                        element.Draw(this.Graphics, pen);
                        return;
                    }
                }

                else
                    continue;
            }
        }

        public void CheckLastElement()
        {
            var lastElement = Elements.Last();

            foreach (Figure element in Elements)
            {
                if (element.Equals(lastElement))
                    element.IsLastElement = true;
                else
                    element.IsLastElement = false;
            }
        }
    }
}
