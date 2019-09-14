using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_HW_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Function line = new Line(3, 1);
            Function hyp = new Hyperbola();
            Function cub = new Cube(2, 3, 4);

            Function[] fArray = new Function[] {line, hyp, cub };

            foreach (var func in fArray)
            {
                func.PrintFx(5);
            }

            Console.ReadLine();
        }
    }
}
