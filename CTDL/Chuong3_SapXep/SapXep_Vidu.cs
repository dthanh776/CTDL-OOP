using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            NhapMang(arr);
            XuatMang(arr);
            Console.WriteLine();

            int left;
            int right;
            //SelectionSortTangDan(arr);
            //Console.WriteLine("Tang dan");
            //XuatMang(arr);

            //Console.WriteLine();
            //Console.WriteLine("Giam dan");
            //SelectionSortGiamDan(arr);
            //XuatMang(arr);


            //InsertionSort(arr);
            //XuatMang(arr);

            //Console.WriteLine();
            //InterChangeSort(arr);
            //XuatMang(arr);


            Console.WriteLine();
            //BubbleSort(arr);
            //XuatMang(arr);

            QuickSort(arr, 0, arr.Length - 1);
            XuatMang(arr);

            Console.ReadKey();

        }
        static void NhapMang(int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(0, 10);
            }
        }
        static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T tam = a;
            a = b;
            b = tam;
        }
        static void SelectionSortTangDan(int[] arr)
        {
            int min, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                // Swap(ref arr[min], ref arr[i]);
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }
        static void SelectionSortGiamDan(int[] arr)
        {
            int max, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[max])
                    {
                        max = j;
                    }
                }
                //Swap(ref arr[max], ref arr[i]);
                temp = arr[max];
                arr[max] = arr[i];
                arr[i] = temp;
            }
        }
        static void InsertionSort(int[] arr)
        {
            int i, pos;
            int v; // luu gia tri arr[i] trang bi ghi de khi doi cho
            for (i = 1; i < arr.Length; i++)
            {
                v = arr[i];
                pos = i - 1; // tim vi tri chen
                while (pos >= 0 && v < arr[pos])
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v;
            }

        }
        static void InterChangeSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        Swap(ref arr[j], ref arr[i]);
                    }
                }
            }
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j -1]);
                    }
                }
            }
        }
        static void QuickSort (int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int i = left, j = right, mid = arr[(left + right) / 2];
            while (i <= j)
            {
                while (arr[i] < mid)
                    i++;
                while (arr[j] > mid)
                    j--;
                if (i <= j)
                {
                    Swap(ref arr[j], ref arr[i]);
                    i++;
                    j--;
                }
            }
            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }
    }
}
