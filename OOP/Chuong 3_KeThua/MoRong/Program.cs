using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Xay dung lop XE gom cac thong tin sau: nhan hieu, gia, nam san xuat.
// Yeu cau cac thong tin nay chi co o lop XE va cac lop dan xuat tu lop XE duoc phep truy cap.
// Xay dung lop MoTo duoc ke thua tu lop xe va co them cac thonog tin:
// So cho ngoi, trong tai va cac phuong thuc nhap xuat du lieu.
// Xay dung chuong trinh chinh thuc hien nhap vao danh sach n OTo sau do hien thi danh sach
// In ra cac o to co so cho ngoi nhieu nhat

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So luong oto");
            int n = int.Parse(Console.ReadLine());

            OTo[] oto = new OTo[n];
            Console.WriteLine("Nhap thong tin xe: ");
            for (int i = 0; i < n; i++)
            {
                oto[i] = new OTo();
                Console.Write($"O to thu {i+1} ");
                oto[i].Nhap();
            }

            Console.WriteLine("------- Danh sach o to vua nhap----------");
            for (int i = 0; i < n; i++)
            {
                oto[i].Xuat();
            }

            Console.WriteLine("--------------------");
            int max = 0;
            int vt = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < oto[i].SoChoNgoi)
                {
                    max = oto[i].SoChoNgoi;
                    vt = i;
                }
                Console.WriteLine("O to co so cho ngoi nhieu nhat");
                oto[i].Xuat();
            }
            Console.ReadKey();
        }
    }
}
