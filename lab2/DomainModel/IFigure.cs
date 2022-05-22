using System;
using System.Drawing;

namespace DomainModel
{
    public interface IFigure
    {
        int X1 { get; set; }

        int Y1 { get; set; }

        int X2 { get; set; }

        int Y2 { get; set; }

        bool IsLastElement { get; set; }

        bool IsFillNull { get; set; }

        bool IsErased { get; set; }

        string TypeOfElement { get; set; }

        Color BorderColor { get; set; }
        String BorderColorName { get; set; }

        Color FillColor { get; set; }
        String FillColorName { get; set; }

        float Width { get; set; }

        virtual void UpdateOnMouseMove(int x, int y)
        {
        }

        virtual void Draw(Graphics g, Pen pen)
        {
        }
    }
}
