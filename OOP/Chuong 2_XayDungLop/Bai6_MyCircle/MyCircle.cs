using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai6
{
    class MyCircle
    {
        private MyPoint center;
        private int radius;
        private static int numOfMyPoint;
        public MyPoint Center
        {
            get { return center; }
            set { center = value; }
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public static int NumOfMyPoint
        {
            get { return NumOfMyPoint; }
            set { numOfMyPoint = value; }
        }
        public MyCircle()
        {
            center = new MyPoint();
            this.radius = 1;
            numOfMyPoint++;
        }
        public MyCircle(int x, int y , int radius)
        {
            center = new MyPoint();
            center.X = x;
            center.Y = y;
            this.radius = radius;
            numOfMyPoint++;
        }
        public MyCircle(MyPoint center, int radius)
        {
            this.center = new MyPoint();
            this.radius = radius;
            numOfMyPoint++;
        }
        public int getCenterX()
        {
            return center.X;
        }
        public void setCenterY(int y)
        {
            center.Y = y;
        }
        public int getCenterY()
        {
            return center.Y;
        }
        public void setCenterX(int x)
        {
            center.X = x;
        }
        public int[] GetCenterXY()
        {
            int[] result = new int[2];
            result[0] = center.X;
            result[1] = center.Y;
            return result;
        }
        public void setCenterXY(int x, int y)
        {
            center.X = x;
            center.Y = y;
        }
        // Tinh dien tich
        public double GetArea()
        {
            double result = 3.14 * radius * radius;
            return result;
        }
        // Tinh chu vi
        public double GetCircumference()
        {
            double result = 3.14 * 2 * radius;
            return result;
        }
        public double Distance (MyCircle c)
        {
            double d = Math.Sqrt(Math.Pow((c.getCenterX() - this.center.X), 2.0) + Math.Pow((c.getCenterY() - this.center.Y), 2.0));
            return d;
        }
        public string toString()
        {
            string str = $"({center.X},{center.Y})-{radius}";
            return str;
        }
    }
}
