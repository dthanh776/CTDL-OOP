using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Queue
    {
        // field
        private Node _first, _last;
        private int _size;
        public Queue()
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

            set
            {
                _size = value;
            }
        }

        internal Node First
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

        internal Node Last
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
        //Method
        public void EnQueue(int data)
        {
            Node pNew = new Node(data);
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
            _size++;
        }
        public int DeQueue()
        {
            if (_first == null)
            {
                throw new Exception("Queue is empty");
            }
            int tam = _first.Data;
            _first = _first.Next;
            if (_last == null)
            {
                _last = null;
            }
            _size--;
            return tam;
        }
        public void Clear()
        {
            _first = _last = null;
            _size = 0;
        }
        public int Peek()
        {
            if (_first == null)
            {
                throw new Exception("Queue is empty");
            }
            return _first.Data;
        }
        public void Display()
        {
            if (_first == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (Node p = _first; p != null ; p = p.Next)
                {
                    Console.WriteLine(p.Data);
                }
            }
        }
    }
}
