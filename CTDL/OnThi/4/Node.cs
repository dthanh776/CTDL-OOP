﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    class Node
    {
        internal int Data;
        internal Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
