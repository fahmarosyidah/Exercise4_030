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
        char[] osyi = new char[48];
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

        public void push(int element)
        {

        }

        public void pop()
        {

        }

        public void display()
        {
            int tmp;

            if (empty()) //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                //Traverse the list from begginning till end
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                
            }
        }
    }
}
