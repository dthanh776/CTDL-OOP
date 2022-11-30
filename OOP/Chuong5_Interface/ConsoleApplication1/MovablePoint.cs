using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MovablePoint : IMovable
    {
        internal int x;
        internal int y;
        internal int xSpeed;
        internal int ySpeed;

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public int getX()
        {
            return this.x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return this.y;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXSpeed(int xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public int getXSpeed()
        {
            return this.xSpeed;
        }
        public void setYSpeed(int ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public int getYSpeed()
        {
            return this.ySpeed;
        }

        public void moveUp()
        {
            this.x += this.xSpeed;
        }
        public void moveDown()
        {
            this.x -= this.xSpeed;
        }
        public void moveRight()
        {
            this.y += this.ySpeed;
        }
        public void moveLeft()
        {
            this.y -= this.ySpeed;
        }
        public string toString()
        {
            string str = $"x: {x} , y: {y} , xSpeed {xSpeed} , ySpeed {ySpeed}";
            return str;
        }
    }
}
