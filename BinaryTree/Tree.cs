using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root = new Node("fadfm");
        public Tree()
        {
           
        }
        public Tree(string value)
        {
            Root.Value = value;
        }
        public Tree(string value, string left, string right)
        {
            Root.Value = value;
            Root.Left = new Node(left);
            Root.Right = new Node(right);
            
        }

        public void Animals()   
        {
            Node elem = Root;
            string s, rem;
            while (true)
            {
                elem = Root;
                while (elem.Left != null || elem.Right != null)
                {
                    Console.WriteLine(elem.Value);
                    s = Console.ReadLine();
                    if (s == "да")
                        elem = elem.Left;
                    else
                        elem = elem.Right;
                }
                Console.WriteLine($"Это {elem.Value} ?");
                s = Console.ReadLine();
                if (s == "да")
                    Console.WriteLine("Успеx");
                    
                else
                {
                    Console.WriteLine("Какое животное вы загадали?");
                    s = Console.ReadLine();
                    elem.Left = new Node(s);
                    Console.WriteLine($"Что отличает {s} от {elem.Value}?");
                    s = Console.ReadLine();
                    rem = elem.Value;
                    elem.Value = $"У него есть {s} ?";
                    elem.Right = new Node(rem);
                }
                Console.WriteLine();
            }
        }
    }
}
