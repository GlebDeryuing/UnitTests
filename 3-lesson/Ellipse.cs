using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3_lesson
{
    class Ellipse : Shape
    {
        public Ellipse(double A1, double A2, double B1, double B2) : base(A1, A2, B1, B2)
        { }
        public override double Distance(PointF point1)
        {
            return 1;
        }
    }
}
