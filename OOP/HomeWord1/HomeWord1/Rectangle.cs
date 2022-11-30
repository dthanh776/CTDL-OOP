using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWord1
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 3;
            this.width = 2;
        }
        ~Rectangle() { }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void setLeng(int length)
        {
            this.length = length;
        }
        public int getLeng()
        {
            return this.length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }
        public int getWidth()
        {
            return this.width;
        }

        public int getArea()
        {
            return this.length * this.width;
        }
        public string toString()
        {
            string str = "";
            str = $"{"Chieu dai: " + this.getLeng() + " - " + "Chieu rong: " + this.getWidth()+ " - " + "Dien tich: " + this.getArea()}";
            return str;
        }
    }
}
