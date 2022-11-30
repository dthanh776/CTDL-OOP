using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Shape
    {
        protected string color;
        protected bool filled;

        public Shape() { }
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public bool Filled
        {
            get
            {
                return filled;
            }

            set
            {
                filled = value;
            }
        }

        public abstract double getArea();

        public abstract double getPerimeter();

        public abstract string toString();

    }
}
