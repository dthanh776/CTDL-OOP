using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Chuong3
{
    public class Cylinder:Circle
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double radius)
        {
            this.Radius = radius;
        }
        public Cylinder(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }
        public Cylinder(double radius, double height, string color)
        {
            this.Radius = radius;
            this.Height = height;
            this.Color = color;
        }
        public double getVolume()
        {
            double volume = base.getAtea() * height;
            return volume;
        }
        public new string toString()
        {
            string s = $"circle[radius: {base.Radius}, color: {base.Color}, height: {height}]";
            return s;
        }
    }
}
