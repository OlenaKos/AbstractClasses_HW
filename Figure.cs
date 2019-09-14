using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    abstract class Figure
    {
        abstract public double GetArea();
        abstract public double GetPerimeter();
        abstract public void PrintType();

        public Figure()
        { 
        
        }

    }
}
