using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong oto: ");
            int n = int.Parse(Console.ReadLine());
            OTo[] oto = new OTo[n];

            Console.WriteLine("Nhap thong tin o to");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Oto thu {i + 1}");
                oto[i] = new OTo();
                oto[i].Nhap();
            }

            Console.WriteLine("Danh sach o to");

            for (int i = 0; i < n; i++)
            {
                oto[i].Xuat();
            }
            Console.WriteLine("---O to co so cho ngoi nhieu nhat---");
            int max = 0;
            int vt = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < oto[i].SoChoNgoi)
                {
                    oto[i].SoChoNgoi = max;
                    vt = i;
                }
  
            }
            oto[vt].Xuat();


            
            Console.ReadKey();
        }
    }
}
