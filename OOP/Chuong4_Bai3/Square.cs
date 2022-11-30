using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Square : Rectangle
    {
        public Square() { }
        public Square(double side) : base(side,side) { }

        public Square(double side,string color, bool filled) : base(side, side,color,filled) { }

        public double getSide()
        {
            return Width;
        }
        public void setSide(double side)
        {
            this.Length = side;
        }
        public void setWidth(double side)
        {
            this.Width = side;
        }
        public void setLength(double side)
        {
            this.Length = side;
        }

        public override string toString()
        {
            return base.toString();
        }
    }
}
