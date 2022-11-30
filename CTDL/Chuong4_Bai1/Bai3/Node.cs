using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai3
{
    class Node
    {
        internal Student Data;
        internal Node Next;
        public Node(Student d)
        {
            Data = d;
            Next = null;
        }
    }
}
