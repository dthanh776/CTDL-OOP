using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Point2D
    {
        private float x;
        private float y;
        
        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point2D()
        {
            x = 0.0f;
            y = 0.0f;
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { x = value; }
        }
        public string toString()
        {
            string s = $"X: {x}, Y: {y}";
            return s;
        }
    }
}
