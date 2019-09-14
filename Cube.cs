using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW_2
{
    class Cube : Function
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Cube()
            : base()
        { }

        public Cube(double a, double b, double c)
            : base()
        {
            A = a;
            B = b;
            C = c;
        }
        public override double GetFx(double x)
        {
            return A * x * x + B * x + C;
        }

    }
}
