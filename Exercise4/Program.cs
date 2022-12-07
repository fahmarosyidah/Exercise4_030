using System;

namespace Exercise4
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
