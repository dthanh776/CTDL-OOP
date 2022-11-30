using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double length;

        protected double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        protected double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public Rectangle() { }
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }
        public Rectangle(double width, double length,string color, bool filled):base (color, filled)
        {
            this.Width = width;
            this.Length = length;
        }
        public override double getArea()
        {
            return this.Width * this.Length;
        }

        public override double getPerimeter()
        {
            return (this.Width + this.Length) * 2;
        }
  
        public override string toString()
        {
            return $"{"Chieu dai: "}{Length,-10} {"Cheu rong: "}{Width,-10} {"Chu vi: "}{getPerimeter(),-10}{"Dien tich: "}{getArea(),-10}";
        }

    }
}
