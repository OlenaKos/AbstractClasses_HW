using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW_2
{
    class Hyperbola : Function
    {
        public Hyperbola() : base()
        { 
        
        }

        public override double GetFx(double x)
        {
            return 1 / x;
        }
    }
}
