using System;

    class LinkList
    {
        //khai bao fews
        private Node _first;
        private Node _last;
        private int _size;
        //properties:
        public int Count
        {
            get { return _size; }
        }
        public Node First
        {
            get { return _first; }
        }
        public Node Last
        {
            get { return _last; }
        }
        //constructor:
        public LinkList()
        {
            _first = null;
            _last = null;
            _size = 0;
        }
        //methor:
        //in ra
        public void PrintList()
        {
            Console.WriteLine($"{"User",-15}{"Password",-15}");
            for (Node p = _first; p != null; p = p.Next)
            {
                Console.WriteLine($"{p.Data.toString()}");
            }
            Console.WriteLine();
        }
        //Them vao dau
        public void AdddFirst(Admin data)
        {
            Node pNew = new Node(data);
            if (_first == null)
            {
                _first = pNew;
                _last = pNew;
            }
            else
            {
                pNew.Next = _first;
                _first = pNew;
            }
            _size++;
        }
        //Them vao cuoi
        public void AdddLast(Admin data)
        {
            Node pNew = new Node(data);
            if (_first == null)
            {
                _first = pNew;
                _last = pNew;
                //_first = _last = pNew;
            }
            else
            {
                _last.Next = pNew;
                _last = pNew;
                //_last.Next =_last = pNew;
            }
            _size++;
        }
        //Tim vi tri key
        public Node Findkey(string id, string pass)
        {
            for (Node p = _first; p != null; p = p.Next)
            {
                if (p.Data.User == id && p.Data.Password==pass)
                {
                    return p;
                }
            }
            return null;
        }
        //Tim vi tri sau key
        public Node FindPre(string key)
        {
            for (Node pre = _first; pre.Next != null; pre = pre.Next)
            {
                if (pre.Next.Data.User == key)
                {
                    return pre;
                }
            }
            return null;
        }
        public void AddAfter(Node pre, Admin newData)
        {
            if (pre != null)
            {
                Node newNode = new Node(newData);
                newNode.Next = pre.Next;
                pre.Next = newNode;
                if (pre == _last)
                {
                    _last = newNode;
                    _size++;
                }
            }
        }
        //public void Addtruoc(Node pre, int newData)
        //{
        //    if (pre!= null)
        //    {
        //        Node newNode = new Node(newData);
        //        newNode.Next = pre.Next;
        //        pre.Next = newNode;
        //        if (pre == _first)
        //        {
        //            _first = newNode;
        //            _size--;
        //        }
        //    }
        //}
        ///Xoa mot phan tu dau danh sach
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
            else
            {
                Console.WriteLine("Danh sach rong, khong xoa dau!!");
            }
        }
        ///Xoa mot phan tu cuoi danh sach
        public void RemoveLast()
        {
            if (_first != null)
            {
                Console.WriteLine("Mang sau khi xoa");
                if (_first == _last) // danh sach co 1 pt
                {
                    _first = _last = null;

                }
                else
                {
                    Node pre = FindPre(_last.Data.User);
                    pre.Next = _last.Next; //pre.Next = null;
                    _last = pre;
                }
                _size--;
            }
            else
            {
                Console.WriteLine("Danh sach rong, khong xoa cuoi!!");
            }
        }
        ///xoa phan tu sau key
        public void RemoveAfter(Node p, Admin newdata)
        {
            if (p != null)
            {
                Node del = p.Next;
                if (del != null)
                {
                    p.Next = del.Next;
                    if (del == _last)
                    {
                        _last = p;
                    }
                }
                _size--;
            }
            else
            {
                Console.WriteLine("Khong xoa duoc");
            }
        }
        ///xoa key
        public void RemoveValue(Admin value)
        {
            if (_first.Data.User == value.User)
            {
                RemoveFirst();
            }
            else
            {
                Node pre = FindPre(value.User);
                if (pre != null)
                {
                    Node del = pre.Next;
                    //neu co 1pt
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

            //if (_first != null)
            //{
            //    if (_first.Next == null)//danh sach co 1 pt
            //    {
            //        if (data == _first.Data)
            //        {
            //            RemoveFirst();
            //        }
            //    }
            //    else if (data == _last.Data)
            //    {
            //        RemoveLast();
            //    }
            //    else
            //    {
            //        //goi con tro
            //        Node pre = FindPre(data);
            //        Node del = pre.Next;
            //        pre.Next = del.Next;
            //        _size--;
            //    }
            //}

        }
        //clear
        public void RemoveAll()
        {
            _first = _first = null;
            _size = 0;
            //while (_first != null)
            //{
            //    _first = _first.Next;
            //    _size--;
            //}
            //_last = null;

        }
        //InterchangeSort
        public void InterchangeSort()
        {
            Console.WriteLine("Mang sau khi sap xep la");
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (String.Compare(p.Data.User, q.Data.User) > 0)
                    {
                        swap(ref p.Data, ref q.Data);
                    }
                }
            }
            //xuat 
            PrintList();
        }
        public void swap<SinhVien>(ref SinhVien a, ref SinhVien b)
        {
            SinhVien temp = a;
            a = b;
            b = temp;
        }
        //SelectionSort
        public void SelectionSort()
        {
            Node min;
            Console.WriteLine("Mang sau khi sap xep la");
            for (Node p = _first; p != null; p = p.Next)
            {
                min = p;
                for (Node q = p.Next; q != null; q = q.Next)
                {
                    if (String.Compare(min.Data.User, q.Data.User) > 0)
                    {
                        min = q;
                    }
                }
                swap(ref min.Data, ref p.Data);
            }
            //xuat 
            PrintList();
        }
        //BubbleSort
        public void BubbleSort()
        {
            Node t = _last;
            Node t1 = null;
            for (Node p = _first; p != null; p = p.Next)
            {
                for (Node q = _first; q != t; q = q.Next)
                {
                    if (String.Compare(q.Data.User, q.Next.Data.User) > 0)
                    {
                        swap(ref q.Data, ref q.Next.Data);
                    }
                    t1 = q;
                }
                t = t1;
            }
            Console.WriteLine("Mang sau khi sap xep la");
            PrintList();
        }
        ///Ham Tinh TBC 
        //public double TBCz()
        //{
        //    double TBC = 0;
        //    double tong = 0;
        //    for (Node p = _first; p != null; p = p.Next)
        //    {
        //        tong += p.Data;
        //    }
        //    TBC = tong / _size;
        //    return TBC;
        //}
        //Ham Tim Min cau h
        public string Min()
        {
            string Min = _first.Data.User;
            for (Node p = _first; p != null; p = p.Next)
            {
                if (String.Compare(Min, p.Data.User) > 0)
                {
                    Min = p.Data.User;
                }
            }
            return Min;
        }
        //Ham xoa k phan tu dau danh sach cau k
        public void ResizeAfter(int k)
        {
            //vong lap chay tu 1-k remove first
            for (int i = 0; i < k; i++)
            {
                RemoveFirst();
            }
            //remove value

        }
        //chua su dung
        //public void Removezz(int value)
        //{
        //    if (_first != null)
        //    {
        //        if (_first.Data  == value)
        //        {
        //            //xoa dau
        //            RemoveFirst();
        //        }
        //        else //xoa sau vs giua
        //        {
        //            Node pre = FindPre(value);
        //            if (pre != null)
        //            {
        //                Node del = pre.Next;
        //                pre.Next = del.Next;
        //                if (del == _last)
        //                {
        //                    _last = pre;
        //                }
        //                _size--;
        //            }
        //        }
        //    }

    }


