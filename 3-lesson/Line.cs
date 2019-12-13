using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3_lesson
{
    public class Line: Shape
    {
        public Line(double A1, double A2, double B1, double B2) : base(A1, A2, B1, B2) {}
        public override double Distance (PointF P)
        {
            double d;
            PointF N = NVector(P1, P2);
            PointF PMax = new PointF(P2.X - P1.X, P2.Y - P1.Y);
            double l = VectorDist(PMax);
            PointF DeltaP = new PointF(P.X - P1.X, P.Y - P1.Y);            
            float m = N.X * DeltaP.X + N.Y * DeltaP.Y;
            if (m < 0)
            {
                d = VectorDist(DeltaP);
            }
            else
            {
                if (m > l)
                {
                    PointF PP2 = new PointF(P.X - P2.X, P.Y - P2.Y);
                    d = VectorDist(PP2);
                }
                else
                {
                    PointF PMN = new PointF(P.X - P1.X- m * N.X, P.Y - P1.Y - m * N.Y);
                    d = VectorDist(PMN);
                }
            }
            return d;   
        }
        public PointF NVector(PointF Point1, PointF Point2)
        {
            PointF N = new PointF(Point2.X - Point1.X, Point2.Y - Point1.Y);
            float NMod = (float)(VectorDist(N));
            N.Y = N.Y / NMod;
            N.X = N.X / NMod;
            return N;
        }
    }
}
