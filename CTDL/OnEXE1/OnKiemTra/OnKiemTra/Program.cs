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
            //XuatDSSV(arr);
            XuatTable(arr);

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

            //// Cau 6
            //Console.ForegroundColor = ConsoleColor.Red;
            //InsertionSort(arr);

            //// Cau 7
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //InterchangeSort(arr);

            ////Cau 8
            //Console.ForegroundColor = ConsoleColor.Green;
            //BubbleSort(arr);

            // Cau 12
            //Console.WriteLine("Nhap vao ho ten sinh vien can tim: ");
            //string key = Console.ReadLine();
            //TimSua(arr, key);
            // Cau 13
            //Console.WriteLine("Nhap vao ma sinh vien can tim: ");
            //string key = Console.ReadLine();
            //TimXoa(ref arr, key);

            // CAu 14
            //ThemSinhVienCuoi(ref arr);
            //XuatTable(arr);

            // Cau 15
            //ThemSinhVienDau(ref arr);
            //XuatTable(arr);

            //Cau 16
            //Console.WriteLine("Nhap vao ma sinh vien can tim: ");
            //string key = Console.ReadLine();
            //TimSinhVien(ref arr, key);

            //Cau 17
            //GhiFileXepLoaiKha(arr);

            //Cau 18
            GhiFileDTBDuoi5(arr);
            Console.ReadKey();
        }
        //Cau 1
        static SinhVien[] DocDSSV()
        {
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
        // Cau 2
        static void XuatDSSV(SinhVien[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{"\t ma SV: ",-20}{arr[i].ma}");
                Console.WriteLine($"{"\t ten SV: ",-20}{arr[i].ten}");
                Console.WriteLine($"{"\t ngay sinh: ",-20}{arr[i].ngaySinh}");
                Console.WriteLine($"{"\t diem trung binh: ",-20}{arr[i].diemTrungBinh}");
                Console.WriteLine("\t *************");
            }
        }
        static void XuatTable(SinhVien[] arr)
        {
            Console.WriteLine($"So luong sinh vien: {arr.Length}");
            Console.WriteLine($"{"Ma SV",-12 } {"Ten SV",-17 } {"Ngay sinh",-17 }  {"Diem TB",-15}{"Xep loai",-10}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].ma,-12} {arr[i].ten,-17} {arr[i].ngaySinh.ToString("dd/MM/yyyy"),-17} {arr[i].diemTrungBinh,-15} {XepLoaiSinhVien(arr[i].diemTrungBinh),-10}");
            }
        }

        //Cau 3
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
        static void SelectionSort(SinhVien[] arr)
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

        static int BinarySearch(SinhVien[] arr, string ma)
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
                while (pos >= 0 && String.Compare(v.ten, arr[pos].ten) == -1)
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
        //Cau 8
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
        // Cau 9
        static void QuickSort(SinhVien[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int i = left, j = right;
            double mid = arr[(left + right) / 2].diemTrungBinh;
            while (i <= j)
            {
                while (arr[i].diemTrungBinh < mid)
                    i++;
                while (arr[j].diemTrungBinh > mid)
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

        // Cau 11

        static string XepLoaiSinhVien(double x)
        {
            if (x >= 0 && x <= 3)
            {
                return "Yeu";
            }
            else if (x <= 5)
            {
                return "Trung binh";
            }
            else if (x <= 7)
            {
                return "Trung binh kha";
            }
            else if (x < 8)
            {
                return "Kha";
            }
            else
            {
                return "Gioi";
            }
        }

        //Cau 12
        static void TimSua(SinhVien[] arr, string key)
        {
            int kq = SequenceSearch(arr, key);

            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay {key}");
            }
            else
            {
                Console.WriteLine($"Tim thay {key} tai vi tri {kq} ");
                Console.Write("Nhap ten can sua: ");
                arr[kq].ten = Console.ReadLine();
                XuatTable(arr);
            }
        }
        //Cau 13
        static void TimXoa(ref SinhVien[] arr, string key)
        {
            int kq = SequenceSearch(arr, key);

            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay sinh vien can xoa");
            }
            else
            {
                for (int i = kq; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];

                }
                Array.Resize(ref arr, arr.Length - 1);
                Console.WriteLine("Danh sach sau khi xoa");
                XuatTable(arr);
            }
        }

        // Cau 14
        static void ThemSinhVienCuoi(ref SinhVien[] arr) // Them sinh vien vao cuoi danh sach
        {
            Array.Resize(ref arr, arr.Length + 1);
            Console.WriteLine("Nhap maSV: ");
            arr[arr.Length - 1].ma = Console.ReadLine();
            Console.WriteLine("Nhap ho ten SV: ");
            arr[arr.Length - 1].ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            arr[arr.Length - 1].ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh: ");
            arr[arr.Length - 1].diemTrungBinh = double.Parse(Console.ReadLine());
        }

        // Cau 15
        static void ThemSinhVienDau(ref SinhVien[] arr) // Them sinh vien vao dau danh sach
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            Console.Write("Nhap maSV: ");
            arr[0].ma = Console.ReadLine();
            Console.Write("Nhap ho ten SV: ");
            arr[0].ten = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            arr[0].ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap diem trung binh: ");
            arr[0].diemTrungBinh = double.Parse(Console.ReadLine());
        }

        // Cau 16
        static void TimSinhVien(ref SinhVien[] arr, string key) // Tim sinh vien va them sau
        {
            int kq = SequenceSearch(arr, key);

            if (kq == -1)
            {
                Console.WriteLine($"Khong tim thay sinh vien");
            }
            else
            {
                Array.Resize(ref arr, arr.Length + 1);
                for (int i = arr.Length - 1; i > kq; i--)
                {
                    arr[i] = arr[i - 1];
                }
                Console.Write("Nhap maSV: ");
                arr[kq + 1].ma = Console.ReadLine();
                Console.Write("Nhap ho ten SV: ");
                arr[kq + 1].ten = Console.ReadLine();
                Console.Write("Nhap ngay sinh: ");
                arr[kq + 1].ngaySinh = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap diem trung binh: ");
                arr[kq + 1].diemTrungBinh = double.Parse(Console.ReadLine());
                Console.WriteLine("Danh sach sau khi chen");
                XuatTable(arr);
            }
        }

        // Cau 17

        static void GhiFileXepLoaiKha(SinhVien[] arr)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\XepLoaiKha.txt"))
                {
                    sw.WriteLine($"So luong sinh vien: {arr.Length}");
                    sw.WriteLine($"{"Ma SV",-12 } {"Ten SV",-17 } {"Ngay sinh",-17 }  {"Diem TB",-15}{"Xep loai",-10}");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (XepLoaiSinhVien(arr[i].diemTrungBinh) == "Gioi")
                        {
                            sw.WriteLine($"{arr[i].ma,-12} {arr[i].ten,-17} {arr[i].ngaySinh.ToString("dd/MM/yyyy"),-17} {arr[i].diemTrungBinh,-15} {XepLoaiSinhVien(arr[i].diemTrungBinh)}");
                        }

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Khong ghi duoc file");
            }
        }

        //Cau 18
        static void GhiFileDTBDuoi5(SinhVien[] arr)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\LoaiYeu.txt"))
                {
                    sw.WriteLine($"So luong sinh vien: {arr.Length}");
                    sw.WriteLine($"{"Ma SV",-12 } {"Ten SV",-17 } {"Ngay sinh",-17 }  {"Diem TB",-15}{"Xep loai",-10}");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].diemTrungBinh < 5)
                        {
                            sw.WriteLine($"{arr[i].ma,-12} {arr[i].ten,-17} {arr[i].ngaySinh.ToString("dd/MM/yyyy"),-17} {arr[i].diemTrungBinh,-15} {XepLoaiSinhVien(arr[i].diemTrungBinh)}");
                        }

                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Khong ghi duoc file");
            }
        }

        // Cau 19

        static string TimMaSVDTBMax(SinhVien[] arr)
        {
            string s = null;
            double max = arr[0].diemTrungBinh;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].diemTrungBinh)
                {
                    max = arr[i].diemTrungBinh;
                    s = arr[i].ma;
                }
            }
            return s;
        }
        static void XoaSVDTBMax(ref SinhVien[] arr)
        {
            string key = TimMaSVDTBMax(arr);
            TimXoa(ref arr, key);
        }

        //Cau 
    }
}
