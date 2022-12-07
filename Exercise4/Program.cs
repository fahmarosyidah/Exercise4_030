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
            
        }
    }
}
