using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class LinkedList
    {
        private Node _first;
        private Node _last;
        private int _size;

        public LinkedList()
        {
            this._first = null;
            this._last = null;
            this._size = 0;
        }

        public Node First
        {
            get
            {
                return _first;
            }

            set
            {
                _first = value;
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

        public int Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }
        public void PrintList()
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.Write($"{p.Data,-5}");
            }
            Console.WriteLine($"Count = {_size}");
        }
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (_first == null)
            {
                newNode = _first = _last;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
            }
            _size++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (_first == null)
            {
                _first = _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                _last = newNode;
            }
            _size++;
        }
        public Node Find(int value)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data == value)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
