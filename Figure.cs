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
        public virtual double Area()
        {
            return S;
        }
    }
}
