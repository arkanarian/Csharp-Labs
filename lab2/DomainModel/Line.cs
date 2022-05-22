using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DomainModel
{
    public class Line: Figure
    {
        public override void UpdateOnMouseMove(int x, int y)
        {
            X2 = x;
            Y2 = y;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X1, Y1, X2, Y2);
        }

        public Line()
        {

        }

    }
}
