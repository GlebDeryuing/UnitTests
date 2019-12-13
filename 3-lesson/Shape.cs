using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3_lesson
{
    abstract public class Shape
    {
        public PointF P1 { get; set; }
        public PointF P2 { get; set; }
        public Shape (double A1, double A2, double B1, double B2)
        {

            this.P1 = new PointF((float)A1, (float)B1);
            this.P2 = new PointF((float)A2, (float)B2);
        }
        abstract public double Distance(PointF point);
        
        public double VectorDist (PointF N)
        {
            double NMod = (Math.Sqrt(Math.Pow(N.X, 2) + Math.Pow(N.Y, 2)));
            return NMod;
        }
        
    }
}
