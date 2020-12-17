using System;

namespace BinaryTreeWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>("1", "2" , "3");
            tree.OutputTree();
        }
    }
}
