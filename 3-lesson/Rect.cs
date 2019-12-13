using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3_lesson
{
    public class Rect : Shape
    {
        public Rect(double A1, double A2, double B1, double B2) : base(A1, A2, B1, B2)
        { }
        public override double Distance(PointF P)
        {
            Line line1 = new Line(Math.Min(P1.X, P2.X), Math.Min(P1.X, P2.X), P1.Y, P2.Y);
            Line line2 = new Line(Math.Max(P1.X, P2.X), Math.Max(P1.X, P2.X), P1.Y, P2.Y);
            Line line4 = new Line(P1.X, P2.X, Math.Max(P1.Y, P2.Y), Math.Max(P1.Y, P2.Y));
            Line line3 = new Line(P1.X, P2.X, Math.Min(P1.Y, P2.Y), Math.Min(P1.Y, P2.Y));
            if (P.X < Math.Min(P1.X, P2.X))
            {
                return line1.Distance(P);
            }
            else
            {
                if (P.X > Math.Max(P1.X, P2.X))
                {
                    return line2.Distance(P);
                }
                else
                    if (P.Y > Math.Max(P1.X, P2.X))
                    {
                    return line4.Distance(P);
                    }
                else
                        if (P.Y < Math.Min(P1.X, P2.X))
                {                    
                    return line3.Distance(P);
                }
                else // внутри
                {
                    return -Math.Min(Math.Min(line1.Distance(P), line2.Distance(P)),Math.Min(line3.Distance(P), line4.Distance(P)));
                }

            }
        }
       
    }
}
