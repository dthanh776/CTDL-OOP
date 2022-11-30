using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_LTHDT
{
    public class Circlecs:Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circlecs()
        {
            radius = 1.0;
        }
        public Circlecs(double radius)
        {
            this.Radius = radius;
        }
        public Circlecs(double radius, string color, bool filled)
        {
            this.Radius = radius;
            this.Color = color;
            this.Filled = filled;
        }
        public double getArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
        public double getPerimeter()
        {
            double perimeter = radius * 2 * 3.14;
            return perimeter;
        }
        public string toString()
        {
            string s = $"Circle[radius: {radius}, color: {base.Color}, filled: {base.Filled}, area: {getArea()}, perimeter: {getPerimeter()}]";
            return s;
        }
    }
}
