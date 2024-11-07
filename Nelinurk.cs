using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmnurk
{
    public class Nelinurk: Figure
    {
        public double A = 0;
        public double B = 0;
        public double C = 0;
        public double D = 0;
        public Nelinurk() { }   

        public Nelinurk(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        double P;
        public override double Perimeter()
        {
            P = A + B + C + D;
            return P;
            base.Perimeter();
        }
        public override double Area()
        {
            
            return base.Area();

        }
    }
}
