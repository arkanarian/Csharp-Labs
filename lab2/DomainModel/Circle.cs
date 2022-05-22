using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DomainModel
{
    public class Circle : Figure
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
                g.DrawEllipse(pen, X2, Y2, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));

                if(IsFillNull == false)
                    g.FillEllipse(brush, X2, Y2, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));

                if (IsErased == true)
                    g.FillEllipse(clearbrush, X2, Y2, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            }


            else if (X1 <= X2 && Y1 >= Y2)
            {
                g.DrawEllipse(pen, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillEllipse(brush, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsErased == true)
                    g.FillEllipse(clearbrush, X1, Y2, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }

            else if (X1 >= X2 && Y1 <= Y2)
            {
                g.DrawEllipse(pen, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillEllipse(brush, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsErased == true)
                    g.FillEllipse(clearbrush, X2, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }

            else
            {
                g.DrawEllipse(pen, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsFillNull == false)
                    g.FillEllipse(brush, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));

                if (IsErased == true)
                    g.FillEllipse(clearbrush, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            }
        }

        public Circle()
        {

        }
    }
}
