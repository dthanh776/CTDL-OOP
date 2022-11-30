using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            NhapMang(arr);
            XuatMang(arr);

            Console.Write("Nhap vao key can tim: ");
            int key = int.Parse(Console.ReadLine());
            int kq = TimTuanTu(arr, key);
            if (kq == -1)
            {
                Console.WriteLine("Khong tim thay key trong mang");
            }
            else
            {
                Console.WriteLine($"{key} tim thay o vi tri {kq}");
            }

            Console.Write($"Tim thay {key} tai vi tri: ");
            TimTatCa(arr, key);

            XoaPhanTu(arr, key);


            Console.ReadKey();
        }
        static void NhapMang (int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 3);

               // arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static int TimTuanTu (int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        static void TimTatCa (int[] arr, int key)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    dem++;
                    Console.Write($"{i} \t");
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Ko tim thay");
            }
        }
        static void XoaPhanTu (int[] arr, int key)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    dem++;
                    for (int j = i; j < arr.Length-1; j++)
                       {
                          arr[j] = arr[j + 1];
                       }
                    Array.Resize(ref arr, arr.Length - 1);
                    i--;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong the xoa");
            }
            else
            {
                XuatMang(arr);
            }
        }
    }
}
