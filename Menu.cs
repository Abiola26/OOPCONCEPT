using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{
    public class Menu
    {
        public double a;

        public double p;

        public double q;

        public virtual double Sum(double a, double p)
        { return a + p; }

        public virtual double Mean(double a, double p, double q)
        {
            return a + p + q / 2;
        }

    }
}
