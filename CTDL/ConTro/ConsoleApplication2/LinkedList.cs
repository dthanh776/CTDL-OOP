using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;
        public Node First
        {
            get { return _first; }
        }
        public Node Last
        {
            get { return _last; }
        }
        public int Count
        {
            get { return _size; }
        }
        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }
        public void PrintList()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.Write($"{p.Data,-5}");
            }
            Console.WriteLine($"Count = {_size}");
        }
        public void AddFirst(int newData)
        {
            Node newNode = new Node(newData);
            if (_first == null)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }
        public void AddLast(int newData)
        {
            Node newNode = new Node(newData);
            if (_first == null)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }
        // Ham chen mot nut sau nut pre
        public void AddAfter(Node pre, int d)
        {
            if (pre != null)
            {
                Node pNew = new Node(d);
                pNew.Next = pre.Next;
                pre.Next = pNew;
                if (_last == pre)
                {
                    _last = pNew;
                }
                _size++;
            }
            else
            {
                Console.WriteLine("Khong them sau duoc");
            }
        }
        // Ham tim va tra ve contro dang quan ly node co data la key
        public Node Find(int key)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == key)
                {
                    return p;
                }
            }
            return null;
        }
        // Tim va tra ve con tro dang quan ly node truoc 1 node
        public Node FindPre(int key)
        {
            for (Node q = _first; q.Next != null; q = q.Next)
            {
                if (q.Next.Data == key)
                {
                    return q;
                }
            }
            return null;
        }

        public void RemoveFirst()
        {
            if (_first != null)
            {
                _first = _first.Next;
                if (_first == null)
                {
                    _last = null;
                }
                _size--;
            }
        }
        public void RemoveLast()
        {
            if (_first == _last) // Danh sach rong hoac co 1 nut
            {
                _first = _last = null;
                _size = 0;
            }
            else
            {
                // neu ko co ham FindPre thi lam giong sach
                Node q = FindPre(_last.Data);
                q.Next = null;
                _last = q;
                _size--;
            }
        }
        // Xoa 1 nut sau 1 nut
        public void RemoveAfter(Node pre)
        {
            if (pre != null)
            {
                Node del = pre.Next;
                if (del != null)
                {
                    pre.Next = del.Next;
                    if (del == null)
                    {
                        _last = pre;
                    }
                    _size--;
                }
            }
        }
        // Xoa so nhap vao
        public void RemoveValue(int value)
        {
            if (_first != null)
            {
                if (_first.Data == value) // Xoa dau
                {
                    RemoveFirst(); // Ham vua tao
                }
                else // Xoa giua hoac cuoi
                {
                    Node pre = FindPre(value);
                    if (pre != null)
                    {
                        Node del = pre.Next;
                        pre.Next = del.Next;
                        if (_last != del)
                        {
                            _last = pre;
                        }
                        _size--;
                    }
                }
            }
        }
        // Xoa toan bo
        public void RemoveAll()
        {
            ////Cach 1
            //while (_first != null)
            //{
            //    _first = _first.Next;
            //}
            //_size = 0;
            //_last = null;

            //Cach 2
            _first = _last = null;
            _size = 0;
        }

        // Sap xep InterchangeSort
        public void InterchangeSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (p.Data > q.Data)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
            PrintList();
        }
        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        //Sap xep SelectionSort
        public void SelectionSort()
        {
            Node min;
            for (Node p = _first; p != null; p = p.Next)
            {
                min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (min.Data > q.Data)
                    {
                        min = q;
                    }
                }
                Swap(ref min.Data, ref p.Data);
            }
            PrintList();
        }

        //Sap xep BubbleSort
        public void BubbleSort() // ko thi
        {
            Node t = _last;
            Node t1 = null;
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = _first; q != t; q = q.Next)
                {
                    if (q.Data > q.Next.Data)
                    {
                        Swap(ref q.Data, ref q.Next.Data);
                    }
                    t1 = q;
                }
                t = t1;
            }
            PrintList();
        }
    }
}
