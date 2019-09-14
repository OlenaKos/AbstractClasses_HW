using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Rectangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public string Type { get; set; }

        //constructor
        public Rectangle() : base()
        {
            Type = "Rectangle";
        }

        public Rectangle(double sideA, double sideB) : base()
        {
            SideA = sideA;
            SideB = sideB;
            Type = "Rectangle";
        }

        //realization of abstract class
        public override double GetArea()
        { 
            double area = SideA * SideB;
            return area;
        }
        public override double GetPerimeter()
        {
            double p = (SideA + SideB) * 2;
            return p;
        }
        public override void PrintType()
        {
            Console.WriteLine("Figure type = {0}", Type);
        }
    }
}
