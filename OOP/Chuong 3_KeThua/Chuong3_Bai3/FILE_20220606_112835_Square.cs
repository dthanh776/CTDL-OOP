using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_LTHDT
{
    public class Square:Rectangle
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square()
        {
            side = 0;
        }
        public Square(double side)
        {
            this.Side = side;
        }
        public Square(double side, string color, bool filled)
        {
            this.Side = side;
            this.Color = color;
            this.Filled = filled;
        }
        public void setWidth(double side)
        {
            this.Side = side;
        }
        public void setLength(double side)
        {
            this.Side = side;
        }
        public string toString()
        {
            string s = $"Square[side: {side}, color: {base.Color}, filled: {base.Filled}]";
            return s;
        }
    }
}
