using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex6._01
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public int Data { get; set; }

        public Node(int x)
        {
            Data = x;
        }
    }
}
