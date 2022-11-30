using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Stack
    {
        private Node _top;
        private int _count;

        public Stack()
        {
            this._top = null;
            this._count = 0;
        }

        public Node Top
        {
            get
            {
                return _top;
            }

            set
            {
                _top = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }

        public void Push(char value) // add first
        {
            Node pNew = new Node(value);
            if (_top == null)
            {
                _top = pNew;
            }
            else
            {
                pNew.Next = _top;
                _top = pNew;
            }
            _count++;
        }
        public char Pop()
        {
            if (_top == null)
            {
                throw new Exception("Stack rong!!!");
            }
            else
            {
                char tam = _top.Data;
                _top = _top.Next;
                _count--;
                return tam;
            }
        }
        public void Clear()
        {
            _top = null;
            _count = 0;
        }
        public char Peek()
        {
            if (_top == null)
            {
                throw new Exception("Stack rong!!!");
            }
            return _top.Data;
        }
        public void Print()
        {
            if (_top == null)
            {
                Console.WriteLine("Stack rong!!!");
            }
            else
            {
                for (Node p = _top; p != null; p = p.Next)
                {
                    Console.WriteLine(p.Data);
                }
            }
            Console.WriteLine("Size = " + _count);
        }
    }
}
