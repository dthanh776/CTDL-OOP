using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LinkList
{
    private Node _first;
    private Node _last;
    private int _size;

    //constructors
    public LinkList()
    {
        _first = null;
        _last = null;
        _size = 0;
    }
    //method
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void BubbleSort()
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
    }
    public void SelectionSort()
    {
        Node min;
        for (Node p = _first; p != null; p = p.Next)
        {
            min = p;
            for (Node q = p.Next; q != null; q = q.Next)
            {
                if (q.Data < min.Data)
                {
                    min = q;
                }
            }
            Swap(ref min.Data, ref p.Data);
        }
    }
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
    }
    public void xoaPhanTuGiongNhau()
    {
        for (Node p = _first; p != null; p = p.Next)
        {
            for (Node q = p; q.Next != null;)
            {
                if (p.Data == q.Next.Data)
                {
                    RemoveAfter(q);
                }
                else
                {
                    q = q.Next;
                }
            }
        }
    }
    public void RemoveAll()
    {
        //while(_first!=null)
        //{
        //    _first = _first.Next;
        //    
        //}
        //_size = 0;
        //_last = null;
        _first = _last = null;
        _size = 0;

    }
    public void RemoveValue(int value)
    {
        if (_first != null)
        {
            if (_first.Data == value)
            {
                RemoveFirst();
            }
            else
            {
                Node pre = _first;
                while (pre.Next != null && pre.Next.Data != value)
                {
                    pre = pre.Next;
                }
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
                if (del == _last)
                {
                    _last = pre;
                }
                _size--;
            }
        }
    }
    public void RemoveLast()
    {
        if (_first == _last)
        {
            _first = null;
            _last = null;
            _size = 0;
        }
        else
        {
            Node q = FindPre(_last.Data);
            q.Next = null;
            _last = q;
            _size--;
        }
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
    public void AddAfter(Node pre, int d)
    {
        if (pre != null)
        {
            Node pNew = new Node(d);
            pNew.Next = pre.Next;
            pre.Next = pNew;
            if (pre == _last)
            {
                _last = pNew;
            }
            _size++;
        }
    }
    public Node Find(int key)
    {
        for (Node i = _first; i != null; i = i.Next)
        {
            if (i.Data == key)
            {
                return i;
            }
        }
        return null;
    }
    public Node FindPre(int key)
    {
        for (Node i = _first; i.Next != null; i = i.Next)
        {
            if (i.Next.Data == key)
            {
                return i;
            }
        }
        return null;
    }

    public void AddLast(int d)
    {
        Node pNew = new Node(d);
        if (_first == null)
        {
            _first = pNew;
            _last = pNew;
        }
        else
        {
            _last.Next = pNew;
            _last = pNew;
        }
    }
    public void printList()
    {
        if (_first == null)
        {
            Console.WriteLine("Danh sach rong!!!");
        }
        else
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.Write($"{p.Data,-5}");
            }
            Console.WriteLine($"\nCount = {_size}");

        }

    }
    public void PrintList()
    {
        Node p = _first;
        while (p != null)
        {
            Console.WriteLine(p.Data + " ");
            p = p.Next;
        }
        Console.WriteLine("Cout: " + _size);
    }
    //properties
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
    }
    public int Count
    {
        get
        {
            return _size;
        }
    }
}

