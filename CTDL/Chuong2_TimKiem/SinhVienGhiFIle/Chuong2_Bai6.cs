using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SinhVienGhiFIle
{
    struct MonHoc
    {
        public string maMH, tenMH;
        public int soTC;
        public double diem;
    }
    struct SinhVien
    {
        public string maSV, hoTen;
        public DateTime ngaySinh;
        public int soMH;
        public MonHoc[] arrMH;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien[] arrSV = DocDSSV();
            GhiDSSV(arrSV);

            Console.Write("Nhap vao ten sinh vien can tim: ");
            string keyTenSV = Console.ReadLine();


            TimSinhVien(arrSV, keyTenSV);
            XoaSinhVien(ref arrSV, keyTenSV);

            SinhVien dtbMax = TimSV_DTBMax(arrSV);
            Console.WriteLine(dtbMax.hoTen);
            Console.WriteLine(TinhTB(dtbMax));

            GhiSV_DTBMax(arrSV);
            Console.ReadKey();
        }
        static void GhiSV_DTBMax (SinhVien[] arrSV)
        {
            SinhVien dtbMax = TimSV_DTBMax(arrSV);
            using (StreamWriter sW = new StreamWriter("D:\\SVMax.txt"))
            {
                sW.WriteLine($"{"\tMaSV: ",-20}{dtbMax.maSV}");
                sW.WriteLine($"{"\tHo ten: ",-20}{dtbMax.hoTen}");
                sW.WriteLine($"{"\tNgay Sinh: ",-20}{dtbMax.ngaySinh}");
                sW.WriteLine($"Danh Sach: {dtbMax.maSV} mon da hoc");
                sW.WriteLine($"{"MaMH",-15}{"TenMH",-15}{"SoTC",-15}{"DiemTB",-15}");
                for (int k = 0; k < dtbMax.arrMH.Length; k++)
                {
                    sW.WriteLine($"{dtbMax.arrMH[k].maMH,-15}{dtbMax.arrMH[k].tenMH,-15}{dtbMax.arrMH[k].soTC,-15}{dtbMax.arrMH[k].diem,-15}");
                }
                sW.WriteLine($"Diem trung binh: {TinhTB(dtbMax)}");
                sW.WriteLine("*********************");
            }
        }
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
                    arr[i].maSV = t[0];
                    arr[i].hoTen = t[1];
                    arr[i].ngaySinh = DateTime.Parse(t[2]);
                    arr[i].soMH = int.Parse(t[3]);
                    arr[i].arrMH = new MonHoc[arr[i].soMH];
                    int q = 4;

                    for (int k = 0; k < arr[i].soMH; k++)
                    {
                        arr[i].arrMH[k].maMH = t[q++];
                        arr[i].arrMH[k].tenMH = t[q++];
                        arr[i].arrMH[k].soTC = int.Parse(t[q++]);
                        arr[i].arrMH[k].diem = double.Parse(t[q++]);
                    } 
                }
            }
            return arr;
        }
        static void GhiDSSV(SinhVien[] arr)
        {
            using (StreamWriter sW = new StreamWriter("D:\\Thanh.txt"))
            {
                sW.WriteLine("****Xuat Danh Sach Sinh Vien****");
                for (int i = 0; i < arr.Length; i++)
                {
                    sW.WriteLine($"{"\tMaSV: ",-20}{arr[i].maSV}");
                    sW.WriteLine($"{"\tHo ten: ",-20}{arr[i].hoTen}");
                    sW.WriteLine($"{"\tNgay Sinh: ",-20}{arr[i].ngaySinh}");
                    sW.WriteLine($"Danh Sach: {arr[i].maSV} mon da hoc" );
                    sW.WriteLine($"{"MaMH",-15}{"TenMH",-15}{"SoTC",-15}{"DiemTB",-15}");
                    for (int k = 0; k < arr[i].arrMH.Length; k++)
                    {
                        sW.WriteLine($"{arr[i].arrMH[k].maMH,-15}{arr[i].arrMH[k].tenMH,-15}{arr[i].arrMH[k].soTC,-15}{arr[i].arrMH[k].diem,-15}");
                    }
                    sW.WriteLine($"Diem trung binh: {TinhTB(arr[i])}");
                    sW.WriteLine("*********************");
                }
            }
        }
        static int TimSinhVien(SinhVien[] arr, string hoTen)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid].hoTen == hoTen)
                {
                    return mid;
                }
                else if (String.Compare(arr[mid].hoTen, hoTen) == -1)
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
        static void XoaSinhVien(ref SinhVien[] arr, string tenSinhVien)
        {
            int kq = TimSinhVien(arr, tenSinhVien);
            if (kq == -1)
            {
                Console.WriteLine("Khong xoa duoc");
            }
            else
            {
                for (int i = kq; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
        }
        static double TinhTB (SinhVien sv)
        {
            double tongDiem = 0.0;
            int tongTC = 0;

            for (int i = 0; i < sv.arrMH.Length;i++)
            {
                tongDiem += sv.arrMH[i].diem * sv.arrMH[i].soTC;
                tongTC += sv.arrMH[i].soTC;
            }
            return tongDiem / tongTC;
        }

        static SinhVien TimSV_DTBMax (SinhVien[] arr)
        {
            SinhVien max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (TinhTB(max) < TinhTB(arr[i]))
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
