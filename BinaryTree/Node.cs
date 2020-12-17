using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public  string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set;}
        public Node(string value)
        {
            this.Value = value;
        }
        public Node(string value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

    }
}
