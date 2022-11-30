using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Chuong3
{
    public class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        ~Circle() { }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Circle (double radius)
        {
            this.Radius = radius;
        }
        public Circle (double radius, string color)
        {
            this.Radius = radius;
            this.Color = color; 
        }
        public double getAtea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }
        public string toString()
        {
            string s = $"circle[radius: {radius}, color: {color}]";
            return s;
        }
    }
}
