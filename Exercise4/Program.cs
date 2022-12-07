using System;

namespace Exercise4
{

    class Stacks
    {
        int[] osyi = new int[48];
        int top;
        int n;

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
            top += 1;
        }

        public void pop()
        {
            top -= 1;
        }

        public void display()
        {

            if (empty()) //If stack is empty
                Console.WriteLine("\nStack Empty");
            else
            {
                for (int i = 0; i < top; i++)
                {
                    Console.WriteLine(osyi[i]);
                }
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
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
