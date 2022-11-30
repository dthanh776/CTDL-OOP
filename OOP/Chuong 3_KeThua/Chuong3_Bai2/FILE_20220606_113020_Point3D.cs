using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Point3D:Point2D
    {
        private float z;
        public float Z
        {
            get { return z; }
            set { z = value; }
        }
        public Point3D()
        {
            z = 0.0f;
        }
        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public string toString()
        {
            string s = $"X: {base.X}, Y: {base.Y}, Z: {z}";
            return s;
        }

    }
}
