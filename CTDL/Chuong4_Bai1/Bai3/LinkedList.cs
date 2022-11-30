using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;
        public LinkedList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }
        public int Count
        {
            get { return _size; }
            set { _size = value; }
        }
        public Node First
        {
            get { return _first; }
            set { _first = value; }
        }
        public Node Last
        {
            get { return _last; }
            set { _last = value; }
        }

        public void PrintList()
        {
            if (_first == null)
            {
                Console.WriteLine("Danh sach rong");
            }
            else
            {
                for (Node p = _first; p != null; p = p.Next)
                {
                    Console.WriteLine($"{p.Data.Xuat(),-5}");
                }
                Console.WriteLine($"Count = {_size}");
            }

        }

        //Them vao cuoi danh sach
        public void AddLast(Student d)
        {
            Node newNode = new Node(d);
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
        public void AddFirst(Student newData)
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
        public void AddAfter(Node pre, Student d)
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

        public Node Find(Student key)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.Id == key.Id)
                {
                    return p;
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
            if (_first != null) // danh sach co 1 node
            {
                _first = _last = null;
            }
            else
            {
                Node pre = _first;
                while (pre != _last)
                {
                    pre = pre.Next;
                }
                pre.Next = null;
                _last = pre;
            }
            _size--;
        }

        public Node FindPre(Student key)
        {
            for (Node q = _first; q.Next != null; q = q.Next)
            {
                if (q.Next.Data.Id == key.Id)
                {
                    return q;
                }
            }
            return null;
        }

        public void RemoveValue(Student value)
        {
            if (_first != null)
            {
                if (_first.Data.Id == value.Id) // Xoa dau
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
                        if (_last == del)
                        {
                            _last = pre;
                        }
                        _size--;
                    }
                }
            }
        }
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
        // Sap xep InterchangeSort
        public void InterchangeSort()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (String.Compare(p.Data.Id, q.Data.Id) > 0)
                    {
                        Swap(ref p.Data, ref q.Data);
                    }
                }
            }
            PrintList();
        }
        public void Swap(ref Student a, ref Student b)
        {
            Student t = a;
            a = b;
            b = t;
        }
    }
}
