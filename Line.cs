using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW_2
{
    class Line : Function
    {
        public double A { get; set; }
        public double B { get; set; }

        public Line() : base()
        { }

        public Line(double a, double b) : base()
        {
            A = a;
            B = b;
        }
        public override double GetFx(double x)
        {
            return A * x + B;
        }


    }
}
