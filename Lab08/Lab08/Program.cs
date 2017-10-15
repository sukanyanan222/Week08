using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            stack1.Push(40);
            Console.WriteLine("The stack elements are:");
            foreach (int i in stack1)
            {
                Console.WriteLine(i);
            }
            ArrayList array = new ArrayList(stack1.ToArray());
            Console.WriteLine("\nContents of the copy");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}

    