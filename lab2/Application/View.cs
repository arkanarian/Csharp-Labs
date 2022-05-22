using Laba2;
using System.Drawing;

namespace MVC
{
    public class View
    {
        private Form1 MainForm = null;
        public Graphics Graphics { get; set; }

        public View()
        {
            Graphics = null;
        }

        public Form1 GetMainForm()
        {
            return MainForm;
        }
        public void Update()
        {
            MainForm.Invalidate();
        }

        public void Initialize()
        {
            MainForm = new Form1();
            this.Graphics = MainForm.CreateGraphics();
        }

        public void CreateMenu()
        {
            MainForm.InitializeMenu();
        }
    }
}
