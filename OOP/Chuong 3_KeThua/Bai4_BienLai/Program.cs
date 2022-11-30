using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            BienLai[] bienLai;
            Console.Write("So luong bien lai: ");
            int n = int.Parse(Console.ReadLine());
            bienLai = new BienLai[n];
            for (int i = 0; i < n; i++)
            {
                bienLai[i] = new BienLai();
                Console.WriteLine($"Bien lai thu {i+1}");
                bienLai[i].Nhap();
            }
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += bienLai[i].SoTienPhaiTra();
                bienLai[i].Xuat();
            }
            Console.WriteLine("Tong tien = " + tong);
            Console.ReadKey();
        }
    }
}
