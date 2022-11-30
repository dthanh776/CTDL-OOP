using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(1, "lap trinh", 5);
            Console.WriteLine(sv.toString());
            Console.ReadKey();
        }
    }
}
