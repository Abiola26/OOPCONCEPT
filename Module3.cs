using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{
    public class Module3 : Menu
    {
        public int r;

        public double Sum(double a, double b, double p, double q, double r)
        {
            return a + b + p + q + r;
        }

        public double Remainder(double p, double q)
        {
            double product = p * q;

            return product;

        }

    }
}
