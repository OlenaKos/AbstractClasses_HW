using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public string Type { get; set; }

        //constructor
        public Triangle() : base()
        {
            Type = "Triangle";
        }

        public Triangle(double sideA, double sideB, double sideC) : base()
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Type = "Triangle";
        }

        //realization of abstract class
        public override double GetArea()
        { 
            double p = (SideA + SideB + SideC)/2;
            double area = Math.Sqrt( p*((p - SideA) * (p - SideB) * (p - SideC)));
            return area;
        }
        public override double GetPerimeter()
        {
            double p = (SideA + SideB + SideC);
            return p;
        }
        public override void PrintType()
        {
            Console.WriteLine("Figure type = {0}", Type);
        }
    }
}
