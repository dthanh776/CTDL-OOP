using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class Node
    {
        internal char Data;
        internal Node Next;
        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }
}
