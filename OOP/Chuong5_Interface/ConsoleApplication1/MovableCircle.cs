using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MovableCircle:IMovable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int radius, MovablePoint center)
        {
            this.radius = radius;
            this.center = center;
        }

        public void moveUp()
        {
            this.center.setX(this.center.getX() + this.center.getXSpeed());
        }
        public void moveDown()
        {
            this.center.setX(this.center.getX() - this.center.getXSpeed());
        }

        public void moveRight()
        {
            this.center.setY(this.center.getY() + this.center.getYSpeed());
        }
        public void moveLeft()
        {
            this.center.setY(this.center.getY() - this.center.getYSpeed());
        }
        public string toString()
        {
            string str = $"Center: {this.center.x} ,  {this.center.y}";
            return str;
        }
    }
}
