using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach L1");
            LinkedList L1 = new LinkedList();
            InputList(L1, 10);
            OutPut(L1);


            Console.WriteLine("Danh sach L2");
            LinkedList L2 = new LinkedList();
            InputList(L2, 5);
            OutPut(L2);

            //Them phan tu
            //Console.WriteLine("key: ");
            //int key = int.Parse(Console.ReadLine());

            //Console.WriteLine("tong chan l2: " + TongSoChan(L2));
            //ThemPhanTu(L1, key);
            //OutPut(L1);

            // Xoa so chinh phuong
            Console.WriteLine("Xoa so chinh phuong");
            XoaSCP(L2);
            OutPut(L2);

            Console.ReadKey();
        }
        // Ham nhap
        static void InputList(LinkedList L, int n)
        {
            Random rd = new Random();
            for (int i = 0; i <= n; i++)
            {
                L.AddLast(rd.Next(1, 10));
            }
        }
        // Ham xuat
        static void OutPut(LinkedList L)
        {
            L.PrintList();
        }
        // Them phan tu (tong chan trong danh sach) vao sau x
        static int TongSoChan(LinkedList L)
        {
            int sum = 0;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (p.Data % 2 == 0)
                {
                    sum += p.Data;
                }
            }
            return sum;
        }
        // So chinh phuong
        static bool SCP(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }
        static bool SHH(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
                return true;
            return false;
        }
        static bool SNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int SoLonNhat(LinkedList L)
        {
            int max = L.First.Data;
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (p.Data >= max)
                {
                    max = p.Data;
                }
            }
            return max;
        }

        static void XoaSCP(LinkedList L)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (SCP(p.Data) == true)
                {
                    L.RemoveAfter(p);
                    break;
                }
            }
        }

        static void ThemPhanTu(LinkedList L, int key)
        {
            for (Node p = L.First; p != null; p = p.Next)
            {
                if (key == p.Data)
                {
                    L.AddAfter(p, TongSoChan(L));
                }
            }
        }


    }

}
