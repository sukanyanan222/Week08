using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("Red");
            queue1.Enqueue("Green");
            queue1.Enqueue("Blue");
            queue1.Enqueue("Orange");
            queue1.Enqueue("Yellow");
            Console.WriteLine("The elements in the queue are:");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The element Red is contain in the queue:"
 + queue1.Contains("Red"));
            Console.WriteLine("The element Black is contain in the queue:"
 + queue1.Contains("Black"));
            Console.WriteLine("The element Purple is contain in the queue:"
 + queue1.Contains("Purple"));
            Console.WriteLine("The element Green is contain in the queue:"
 + queue1.Contains("Green"));
            Console.ReadLine();

        }
    }
}

    