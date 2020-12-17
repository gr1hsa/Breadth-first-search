using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeWithGenerics
{
    class Tree<T>
    {
        public Node<T> Root = new Node<T>();
        public Tree()
        {

        }
        public Tree(T value)
        {
            Root.Value = value;
        }
        public Tree(T value, T left, T right)
        {
            Root.Value = value;
            Root.Left = new Node<T>(left);
            Root.Right = new Node<T>(right);

        }
        public void OutputTree()
        {
            var elem = Root;
              OutputElem(Root);
        }
        private void OutputElem(Node<T> a)
        {
            var elem = a;
            if (elem.Left != null)
                OutputElem(elem.Left);
            Console.WriteLine(elem.Value);
            if (elem.Right != null)
                OutputElem(elem.Right);
        }
                
    }
}
