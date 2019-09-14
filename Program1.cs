using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure rect = new Rectangle();
            Figure trian = new Triangle();
            Figure circle = new Circle();

            Figure[] shapes = new Figure[] { rect , trian, circle };

            foreach (var shape in shapes)
            {
                shape.PrintType();
            }

            Console.ReadLine();

        }
    }
}
