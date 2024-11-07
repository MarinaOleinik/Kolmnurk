using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmnurk
{
    public class Triangle: Figure
    {
        public double A = 0;
        public double B = 0;
        public double C = 0;
        public double H = 0;//kõrgus

        public Triangle() { }
        public Triangle(double a) //võrgkülgne kolmnurk
        {
            A = a;
            B = a;
            C = a;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(double ha, double a)
        {
            H = ha;
            A = a;
        }


        public bool ExistTriangle
        {
            get
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public double GetSetA
        {
            get { return A; }
            set { A = value; }
        }
        public double GetSetB
        {
            get { return B; }
            set { B = value; }
        }
        public double GetSetC
        {
            get { return C; }
            set { C = value; }
        }
        public double GetSetH
        {
            get { return H; }
            set { H = value; }
        }
        
        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (A == B && B == C && A == C)
                    {
                        return "võrdkülgne";
                    }
                    else if (A == B || A == C || B == C)
                    {
                        return "võrdhaarne";
                    }
                    else
                    {
                        return "erikülgne";
                    }
                }
                else
                {
                    return "tundmatu tüüp";
                }

            }
        }
        public override double Perimeter()
        {
            return A + B + C;
        }
        public double Perimeter1_2()
        {
            return (A + B + C) / 2;
        }
        double S;
        public override double Area()
        {
            if (ExistTriangle)
            {
                double p;
                p = (A + B + C) / 2;
                S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            else
            {
                S = H * A / 2;
            }
            return S;
            base.Area();
        }
        public string OutputA()
        {
            return A.ToString();
        }
        public string OutputB()
        {
            return B.ToString();
        }
        public string OutputC()
        {
            return C.ToString();
        }
        public string OutputH()
        {
            return H.ToString();
        }

       
    }





}
