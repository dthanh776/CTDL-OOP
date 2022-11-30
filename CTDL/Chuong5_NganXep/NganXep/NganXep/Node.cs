using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NganXep
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
