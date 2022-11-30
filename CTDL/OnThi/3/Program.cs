using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        //goi ham cau 2a
        LinkList L = new LinkList();
        LinkList L1 = new LinkList();
        Console.Write("Count1 = ");
        int n = int.Parse(Console.ReadLine());
        L = Input(n);
        Output(L);
        //Console.ReadKey();
        Console.Write("Count2 = ");
        int m = int.Parse(Console.ReadLine());
        L1 = Input(m);

        Output(L1);
        //goi ham cau 2b
        //Output(L1);
        ////goi ham cau 2c
        //Console.Write(" key= ");
        //int key = int.Parse(Console.ReadLine());
        //ThemX(L, key);
        //goi ham cau 2d
        //XoaSCP(L);
        //goi ham cau 2e
        kiemTraChanL1TrongL2(L, L1);
        //goi ham cau 2f
        Console.WriteLine("Sap xep tang dan L2");
        L1.InterchangeSort();
        Output(L);
        //dung man hinh
        Console.ReadKey();
    }

    static void kiemTraChanL1TrongL2(LinkList L1, LinkList L2)
    {
        int dem = 0;
        LinkList L3 = new LinkList();
        for (Node p = L1.First; p != null; p = p.Next)
        {
            if (p.Data % 2 == 0)
            {
                L3.AddLast(p.Data);
            }
        }
        for (Node p = L3.First; p != null; p = p.Next)
        {
            for (Node q = p.Next; q != null; q = q.Next)
            {
                if (p.Data == q.Data)
                {
                    L3.RemoveValue(q.Data);
                }
            }
        }
        for (Node p = L2.First; p != null; p = p.Next)
        {
            for (Node q = p.Next; q != null; q = q.Next)
            {
                if (p.Data == q.Data)
                {
                    L2.RemoveValue(q.Data);
                }
            }
        }
        for (Node p = L2.First; p != null; p = p.Next)
        {
            if (L3.Find(p.Data) != null)
            {
                dem++;
            }
        }
        Console.WriteLine("Tong so chan L1 xuat hien trong L2 la: " + dem);
    }
    static void XoaSCP(LinkList L)
    {
        for (Node p = L.First; p != null; p = p.Next)
        {
            if (KTSCP(p.Data) == true)
            {
                L.RemoveAfter(p);
                break;
            }
        }

    }

    static bool KTSCP(int n)
    {
        bool check = false;
        for (int i = 0; i < n; i++)
        {
            if (i * i == n)
            {
                check = true;
            }
        }


        return check;
    }
    //Cau 2c: them tong so chan cua danh sach vao sau x
    static void ThemX(LinkList L, int key)
    {
        for (Node p = L.First; p != null; p = p.Next)
        {
            if (key == p.Data)
            {
                L.AddAfter(p, TongSoChan(L));
            }
        }
        Output(L);
    }
    //Tinh tong so chan 
    static int TongSoChan(LinkList L)
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

    //cau 2b: xuat du lieu cho danh sach
    static void Output(LinkList L)
    {
        for (Node p = L.First; p != null; p = p.Next)
        {
            Console.Write($"{p.Data,-5}");
        }
        Console.WriteLine();
    }
    // cau 2a: nhap du lieu cho danh sach
    static LinkList Input(int n)
    {
        LinkList L = new LinkList();
        Random rd = new Random();
        for (int i = 0; i < n; i++)
        {
            L.AddLast(rd.Next(1, 10));
        }
        return L;
    }
}

