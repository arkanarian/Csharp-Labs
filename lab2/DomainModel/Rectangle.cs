using System;
using System.Drawing;

namespace DomainModel
{
    public class Rectangle : Figure
    {
        public override void UpdateOnMouseMove(int x, int y)
        {
            X2 = x;
            Y2 = y;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            SolidBrush clearbrush = new SolidBrush(Color.White);

            if (X1 >= X2 && Y1 >= Y2)
            {
                g.DrawRectangle(pen, X2, Y2, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));

                if (IsFillNull == false)
                    g.FillRectangle(brush, X2 + 1, Y2 + 1, Math.Abs(X1 - 1 - X2), Math.Abs(Y1 - 1 - Y2));

                if(IsErased == true)
                    g.FillRectangle(clearbrush, X2, Y2, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            }

            else if(X1 <= X2 && Y1 >= Y2)
            {
                g.DrawRectangle(pen, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillRectangle(brush, X1 + 1, Y2 + 1, Math.Abs(X2 - 1 - X1), Math.Abs(Y2 + 1 - Y1));

                if (IsErased == true)
                    g.FillRectangle(clearbrush, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }

            else if (X1 >= X2 && Y1 <= Y2)
            {
                g.DrawRectangle(pen, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillRectangle(brush, X2 + 1, Y1 + 1, Math.Abs(X2+1 - X1), Math.Abs(Y2 - 1 - Y1));

                if (IsErased == true)
                    g.FillRectangle(clearbrush, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }

            else
            {
                g.DrawRectangle(pen, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillRectangle(brush, X1 + 1, Y1 + 1, Math.Abs(X2 - 1 - X1), Math.Abs(Y2 - 1 - Y1));

                if (IsErased == true)
                    g.FillRectangle(clearbrush, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
        }

        public Rectangle()
        {

        }
    }
}
