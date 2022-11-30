using System;

    internal class Node
    {
        internal Admin Data;
        internal Node Next;
        public Node(Admin data)
        {
            Data = data;
            Next = null;
        }
    }

