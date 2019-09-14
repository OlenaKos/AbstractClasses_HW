using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW_2
{
    abstract class Function
    {
        abstract public double GetFx(double x);

        public void PrintFx(double x)
        {
            Console.WriteLine("F(x) = {0}", GetFx(x));
        }

        public Function()
        { }
    }
}
