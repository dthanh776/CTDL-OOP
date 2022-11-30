using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OnEXE1
{
    class Program
    {
        struct SinhVien
        {
            public string ma;
            public string ten;
            public DateTime ngaySinh;
            public double diemTrungBinh; 
        }
        static void Main(string[] args)
        {
            SinhVien[] arr = DocDSSV();
            XuatDSSV(arr);

            //Cau 3
            //Console.WriteLine("Nhap vao ma sinh vien can tim: ");
            //string key = Console.ReadLine();
            //int kq = SequenceSearch(arr, key);
            //if (kq == -1)
            //{
            //    Console.WriteLine($"Khong tim thay {key}");
            //}
            //else
            //{
            //    Console.WriteLine($"Tim thay {key} tai vi tri {kq} ");
            //}

            // Cau 4
            //SelectionSort(arr);

            // Cau 5
            //Console.WriteLine("Nhap vao ma sinh vien can tim: ");
            //string key = Console.ReadLine();
            //int kq = BinarySearch(arr, key);
            //if (kq == -1)
            //{
            //    Console.WriteLine($"Khong tim thay {key}");
            //}
            //else
            //{
            //    Console.WriteLine($"Tim thay {key} tai vi tri {kq} ");
            //}

            // Cau 6
            Console.ForegroundColor = ConsoleColor.Red;
            InsertionSort(arr);

            // Cau 7
            Console.ForegroundColor = ConsoleColor.Yellow;
            InterchangeSort(arr);

            //Cau 8
            Console.ForegroundColor = ConsoleColor.Green;
            BubbleSort(arr);

            Console.ReadKey();
        }
        static SinhVien[] DocDSSV() {
            SinhVien[] arr;
            int n = 0;
            using (StreamReader sr = new StreamReader("Input.txt"))
            {
                n = int.Parse(sr.ReadLine());
                arr = new SinhVien[n];
                for (int i = 0; i < n; i++)
                {
                    string[] t = sr.ReadLine().Split('#');
                    arr[i].ma = t[0];
                    arr[i].ten = t[1];
                    arr[i].ngaySinh = DateTime.Parse(t[2]);
                    arr[i].diemTrungBinh = double.Parse(t[3]);                   
                }
                
            }
            return arr;
        }
        static void XuatDSSV (SinhVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{"\t ma SV: ", -20}{arr[i].ma}");
                Console.WriteLine($"{"\t ten SV: ",-20}{arr[i].ten}");
                Console.WriteLine($"{"\t ngay sinh: ", -20}{arr[i].ngaySinh}");
                Console.WriteLine($"{"\t diem trung binh: ",-20}{arr[i].diemTrungBinh}");
                Console.WriteLine("\t *************");
            }
        }
        static int SequenceSearch(SinhVien[] arr, string ma)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (String.Compare(arr[i].ma, ma) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T tam = a;
            a = b;
            b = tam;
        }
        static void SelectionSort (SinhVien[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (String.Compare(arr[j].ma, arr[min].ma) == -1)
                    {
                        min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
            }
            XuatDSSV(arr);
        }

        static int BinarySearch (SinhVien[] arr, string ma)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid].ma == ma)
                {
                    return mid;
                }
                else if (String.Compare(arr[mid].ma, ma) == -1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        static void InsertionSort(SinhVien[] arr)
        {
            int i, pos;
            SinhVien v;
            for (i = 1; i < arr.Length; i++)
            {
                v = arr[i];
                pos = i - 1;
                while (pos >=0 && String.Compare(v.ten , arr[pos].ten) == -1)
                {
                    arr[pos + 1] = arr[pos];
                    pos--;
                }
                arr[pos + 1] = v;
            }
            XuatDSSV(arr);
        }

        static void InterchangeSort(SinhVien[] arr) //Sap xep theo nam
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].ngaySinh.Year < arr[i].ngaySinh.Year)
                    {
                        Swap(ref arr[j], ref arr[i]);
                    }
                }
            }
            XuatDSSV(arr);
        }

        static void BubbleSort(SinhVien[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j].diemTrungBinh < arr[j - 1].diemTrungBinh)
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
            XuatDSSV(arr);
        }
        static void QuickSort(int[] arr, int left, int right)
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
