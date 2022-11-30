using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> A;
            Queue<int> B;
            LinkedList<Ve> C;
        }
        static void XuatA(LinkedList<int> A)
        {
            if (A.Count == 0)
            {
                Console.WriteLine("Khong con ghe TRONG trong rap!!!");
            }
            else
            {
                for (LinkedListNode<int> p = A.First; p != null; p = p.Next)
                {
                    Console.Write(p.Value + " ");
                }
                Console.WriteLine();
            }
        }
        static void GhiC(LinkedList<Ve> C, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (LinkedListNode<Ve> p = C.First; p != null; p = p.Next)
                    {
                        sw.WriteLine($"{p.Value.SoGhe}#{p.Value.Ten}");
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file A.txt de ghi that bai");
            }
        }
        static void GhiA(Queue<int> B, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var item in B)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file B.txt de ghi that bai");
            }
        }
        static void GhiA (LinkedList<int> A , string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (LinkedListNode<int> p = A.First;  p != null;  p = p.Next)
                    {
                        sw.WriteLine(p.Value);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file A.txt de ghi that bai");
            }
        }
        static LinkedList<Ve> DocC(string path)
        {
            LinkedList<Ve> C = new LinkedList<Ve>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() != -1)
                    {
                        string[] t = sr.ReadLine().Split('#');
                        C.AddLast(new Ve(t[0], t[1]));
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file C.txt that bai");
            }
            return C;
        }
        static Queue<int> DocB(string path)
        {
            Queue<int> B = new Queue<int>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() != -1)
                    {
                        B.Enqueue(int.Parse(sr.ReadLine()));
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file B.txt that bai");
            }
            return B;
        }
        static LinkedList<int> DocA(string path)
        {
            LinkedList<int> A = new LinkedList<int>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() != -1)
                    {
                        A.AddLast(int.Parse(sr.ReadLine()));
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file C.txt that bai");
            }
            return A;
        }
        

    }
}
