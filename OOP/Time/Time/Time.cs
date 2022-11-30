using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Time
    {
        public int hour;
        public int minute;
        public int second;

        public Time()
        {
            this.hour = 1;
            this.minute = 2;
            this.second = 3;
        }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public int getHour
        {
            get { return this.hour; }
        }
        public int getMinute
        {
            get { return this.getMinute; }
        }
        public int getSecond
        {
            get { return this.second; }
        }

        public void setHour(int hour)
        {
            this.hour = hour;
        }
        public void setMinute(int minute)
        {
            this.minute = minute;
        }
        public void setSecond(int second)
        {
            this.second = second;
        }


        public bool CheckHour()
        {
            return this.hour <= 24 && this.hour >= 0;
        }
        public bool CheckMinute()
        {
            return this.minute <= 60 && this.minute >= 0;
        }
        public bool CheckSecond()
        {
            return this.second <= 60 && this.second >= 0;
        }

        public string toString()
        {
            return this.hour + ":" + this.minute + ":" + this.second;
        }
        public void OutPut()
        {
            if (CheckHour() == false)
            {
                Console.WriteLine("\nGio khong hop le");
            }
            else if (CheckMinute() == false)
            {
                Console.WriteLine("\nPhut khong hop le");
            }
            else if (CheckSecond() == false)
            {
                Console.WriteLine("\nGiay khong hop le");
            }
            else
            {
                Console.Write(toString());
            }
        }

        public Time NextSecond()
        {
            return new Time(this.hour, this.minute, this.second + 1);
        }
        public Time PreviousSecond()
        {
            return new Time(this.hour, this.minute, this.second - 1);
        }
    }
}
