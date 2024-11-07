using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmnurk
{
    public class Figure
    {
        public double S;
        public double P;
        public double GetSetS
        {
            get
            { return S; }
            set
            { S = value; }
        }
        public virtual double Area()
        {
            return S;
        }
        public virtual double Perimeter() 
        { 
            return P;
        }
    }
}
