using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_LTHDT
{
    public class Rectangle:Shape
    {
        private double width;
        private double length;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }
        public Rectangle(double width, double length,string color, bool filled)
        {
            this.Width = width;
            this.Length = length;
            this.Color = color;
            this.Filled = filled;
        }
        public double getArea()
        {
            double area = width * length / 2;
            return area;
        }
        public double getPerimeter()
        {
            double perometer = 3 * width;
            return perometer;
        }
        public string toString()
        {
            string s = $"rectangle[width: {width}, length: {length}, color: {base.Color}, filled: {base.Filled}, area: {getArea()}, perimeter: {getPerimeter()}]";
            return s;
        }
    }
}
