using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = DocHH(@"E:\InputHH.txt");
           

            Console.WriteLine("Tat ca hang hoa trong kho");
            q.Display();

            Console.WriteLine();

            Console.WriteLine("Phan tu dau");
            q.Peek().Print();

            // Them mot mat hang vao kho
            Console.WriteLine("Them mot mat hang vao kho");
            q.EnQueue(new HangHoa("009","Banh gio",5,10000));
            q.Display();

            // Xuat mot mat hang ra khoi kho
            Console.WriteLine("Xuat mot mat hang vao kho");
            q.DeQueue();
            q.Display();
            Console.ReadKey();
        }
        static Queue DocHH(string path)
        {
            Queue q = new Queue();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() != -1)
                    {
                        string[] t = sr.ReadLine().Split(',');
                        q.EnQueue(new HangHoa(t[0],t[1],t[2],t[3]));
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file that bai!!");
            }
            return q;
        }

    }
}
