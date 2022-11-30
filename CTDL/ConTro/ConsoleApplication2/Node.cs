using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class Node
    {
        internal int Data;
        internal Node Next;
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
}
