using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    class LinkedList
    {
        private Node first, last;
        private int size;

        public LinkedList()
        {
            this.first = null;
            this.last = null;
            this.size = 0;
        }

        public int Size { get => size; set => size = value; }
        internal Node First { get => first; set => first = value; }
        internal Node Last { get => last; set => last = value; }

        // Them phan tu vao dau danh sach
        public void AddFirst(int value)
        {

            Node newNode = new Node(value);
            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
            size++;
        }
        // Them phan tu vao cuoi danh sach
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            size++;
        }
        // Them phan tu vao sau phan tu khac
        public void AddAfter(Node pre, int value)
        {
            if (pre != null)
            {
                Node newNode = new Node(value);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == last)
                {
                    last = newNode;
                }
            }
            else
            {
                Console.WriteLine("Khong them duoc");
            }
            size++;
        }
        // Xoa phan tu dau danh sach
        public void RemoveFirst()
        {
            Node p = first;
            if (p != null)
            {
                first = p.Next;
                if (first == null)
                {
                    last = null;
                }
                size--;
            }
        }
        // Xoa phan tu cuoi danh sach
        public void RemoveLast()
        {
            if (first == last)
            {
                first = last = null;
                size = 0;
            }
            else
            {
                Node pre = first;
                while (pre.Next != last)
                {
                    pre = pre.Next;
                }
                pre.Next = null;
                last = pre;
                size--;
            }
        }
        // Xoa phan tu sau mot phan tu khac
        public void RemoveAfter(Node pre)
        {
            if (pre != null)
            {
                Node p = pre.Next;
                if (p != null)
                {
                    pre.Next = p.Next;
                    if (p == null)
                    {
                        last = pre;
                    }
                    size--;
                }
            }
        }
        // Xoa phan tu co gia tri value
        public void RemoveValue(int value)
        {
            if (first != null)
            {
                if (first.Data == value) // Xoa dau
                {
                    RemoveFirst();
                }
                else
                {
                    Node pre = first;
                    while (pre.Next != null && pre.Next.Data != value)
                    {
                        pre = pre.Next;
                    }
                    if (pre != null)
                    {
                        Node del = pre.Next;
                        if (del != null)
                        {
                            pre.Next = del.Next;
                            if (pre.Next == null)
                            {
                                last = pre;
                            }
                            size--;
                        }
                    }
                }
            }
        }
        // Xoa toan bo sanh sach
        public void Clear()
        {
            first = last = null;
            size = 0;
        }
        // Tim kiem 
        public Node FindNode(int key)
        {
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.Data == key)
                {
                    return p;
                }
            }
            return null;
        }
        public Node FindNodePre(int key)
        {
            for (Node p = first; p != null; p = p.Next)
            {
                if (p.Next.Data == key)
                {
                    return p;
                }
            }
            return null;
        }
        // Sap xep
        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public void SelectionSort()
        {
            Node min;
            for (Node p = first; p != null; p = p.Next)
            {
                min = p;
                for (Node q = first; q != null; q = q.Next)
                {
                    if (min.Data > q.Data)
                    {
                        min = q;
                    }
                    Swap(ref min.Data, ref p.Data);
                }
            }
        }

        public void InterchangeSort()
        {
            for (Node p = first; p != null; p = p.Next)
            {
                for (Node q = first; q != null; q = q.Next)
                {
                    if (p.Data > q.Data)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
        }
        // Xuat danh sach
        public void PrintList()
        {
            if (first == null)
            {
                Console.WriteLine("Danh sach rong");
            }
            else
            {
                for (Node p = first; p != null; p = p.Next)
                {
                    Console.Write($"{p.Data,-5}");
                }
                Console.WriteLine($"Size: {size}");
            }
        }
    }
}
