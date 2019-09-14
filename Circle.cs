using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Circle : Figure
{
        public double Radius { get; set; }
        public string Type { get; set; }

        //constructor
        public Circle() : base()
        {
            Type = "Circle";
        }

        public Circle(double radius) : base()
        {
            Radius = radius;
            Type = "Circle";
        }

        //realization of abstract class
        public override double GetArea()
        { 
            double area = Math.PI * Radius * Radius;
            return area;
        }
        public override double GetPerimeter()
        {
            double p = 2 * Math.PI * Radius;
            return p;
        }
        public override void PrintType()
        {
            Console.WriteLine("Figure type = {0}", Type);
        }
    }
}
