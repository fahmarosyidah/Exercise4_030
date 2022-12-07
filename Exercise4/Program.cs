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

    class Stacks
    {
        int[] osyi = new int[48];
        int top;

        public Stacks()
        {
            top = -1;
        }

        bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
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
