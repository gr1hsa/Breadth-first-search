using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeWithGenerics
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node()
        {

        }
        public Node(T value)
        {
            Value = value;
        }
        /*public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }*/
    }
}
