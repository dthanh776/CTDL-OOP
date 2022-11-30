using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();          
            HienThi(time);
            

            Time time1 = new Time(24,61,33);
            HienThi(time1);

            Nhap(time);
            Console.Write("Gio phut giay nguoi dung vua nhap la: ");
            HienThi(time);


            Console.ReadKey();
        }

        static void HienThi (Time time)
        {
            //Console.WriteLine(time.toString());
            time.OutPut();
            time.NextSecond();
        }
        static void Nhap(Time time)
        {
            Console.Write("\nInput hour: ");
            time.hour = int.Parse(Console.ReadLine());

            Console.Write("Input minute: ");
            time.minute = int.Parse(Console.ReadLine());

            Console.Write("Input second: ");
            time.second = int.Parse(Console.ReadLine());
        }
    }
}
