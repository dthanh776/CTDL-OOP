using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong2_Bai6
{
    class MyPoint
    {
        private int x;
        private int y;
        
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }
        // Ham sao chep
        public MyPoint(MyPoint point)
        {
            this.x = point.x;
            this.y = point.y;
        }
    }
}
