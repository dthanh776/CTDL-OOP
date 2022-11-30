using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_LTHDT
{
    public class Shape
    {
        private string color;
        private bool filled;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }
        public Shape()
        {
            color = "red";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }
        public string toString()
        {
            string s = $"Shape[color: {color}, filled: {filled}]";
            return s;
        }
    }
}
