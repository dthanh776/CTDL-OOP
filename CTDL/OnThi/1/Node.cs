using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    {
        // fews
        internal int Data;
        internal Node Next;

        //Constructor
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

    }
}
