using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle : Shape
    {
        private double radius;
        
        public Circle() { }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public override double getArea()
        {
            return Math.Round(Math.PI * this.radius * this.radius, 2);
        }

        public override double getPerimeter()
        {
            return Math.Round(Math.PI * this.radius * 2, 2);
        }
        public override string toString()
        {
            return $"{"Duong kinh: "}{Radius,-10} {"Dien tich: "}{getArea(),-10} {"Chu vi: "}{getPerimeter(),-10}";
        }
    }
}
