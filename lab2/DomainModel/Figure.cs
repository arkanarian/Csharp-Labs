using System;
using System.Drawing;

namespace DomainModel
{
    public class Figure : IFigure
    {
        public int X1 { get; set; }

        public int Y1 { get; set; }

        public int X2 { get; set; }

        public int Y2 { get; set; }

        public bool IsLastElement { get; set; }

        public bool IsFillNull { get; set; }

        public bool IsErased { get; set; }

        public string TypeOfElement { get; set; }

        public Color BorderColor { get; set; }
        public String BorderColorName { get; set; }

        public Color FillColor { get; set; }
        public String FillColorName { get; set; }

        public float Width { get; set; }

        public Figure()
        {
            IsFillNull = true;
            IsErased = false;
            Width = 1;
            BorderColor = Color.Black;
            FillColor = Color.White;
        }

        public virtual void UpdateOnMouseMove(int x, int y)
        {
        }

        public virtual void Draw(Graphics g, Pen pen)
        {
        }
    }
}
