using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LinkedList
    {
        private Node _first, _last;
        private int _size;

        public LinkedList()
        {
            this._first = null;
            this._last = null;
            this._size = 0;
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public Node First
        {
            get
            {
                return _first;
            }
        }

        public Node Last
        {
            get
            {
                return _last;
            }

            set
            {
                _last = value;
            }
        }
        // 1a
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
        // 1b
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
        // 1c
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
        // 1d
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
        // 1e
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
        public void PrintList()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.Write($"{p.Data,-5}");
            }
            Console.WriteLine($"Count = {_size}");
        }
    }
}
