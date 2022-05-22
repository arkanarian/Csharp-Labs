using System;
using System.Drawing;
using DomainModel;

namespace Plugin
{
    public class Triangle : Figure
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
                Point[] points = new Point[] { new Point { X = X2, Y = Y1 }, new Point { X = X1 - (X1 - X2) / 2, Y = Y2 }, new Point { X = X1, Y = Y1 } };
                g.DrawPolygon(pen, points);

                if (IsFillNull == false)
                    g.FillPolygon(brush, points);

                if (IsErased == true)
                    g.FillPolygon(clearbrush, points);
            }

            else if (X1 <= X2 && Y1 >= Y2)
            {
                Point[] points = new Point[] { new Point { X = X1, Y = Y1 }, new Point { X = X1 + (X2 - X1) / 2, Y = Y2 }, new Point { X = X2, Y = Y1 } };
                g.DrawPolygon(pen, points);

                if (IsFillNull == false)
                    g.FillPolygon(brush, points);

                if (IsErased == true)
                    g.FillPolygon(clearbrush, points);
            }

            else if (X1 >= X2 && Y1 <= Y2)
            {
                Point[] points = new Point[] { new Point { X = X2, Y = Y2 }, new Point { X = X1 - (X1 - X2) / 2, Y = Y1 }, new Point { X = X1, Y = Y2 } };
                g.DrawPolygon(pen, points);

                if (IsFillNull == false)
                    g.FillPolygon(brush, points);

                if (IsErased == true)
                    g.FillPolygon(clearbrush, points);
            }

            else
            {
                Point[] points = new Point[] { new Point { X = X1, Y = Y2 }, new Point { X = X1 + (X2 - X1) / 2, Y = Y1 }, new Point { X = X2, Y = Y2 } };
                g.DrawPolygon(pen, points);

                if (IsFillNull == false)
                    g.FillPolygon(brush, points);

                if (IsErased == true)
                    g.FillPolygon(clearbrush, points);
            }
        }

        public Triangle()
        {

        }
    }
}
