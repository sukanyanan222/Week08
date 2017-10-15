using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("RED");
            queue1.Enqueue("BLUE");
            queue1.Enqueue("YELLOW");
            queue1.Enqueue("GREEN");

            Console.WriteLine("The elements in the queue are:" + queue1.Count);
            queue1.Clear();
            Console.WriteLine("The elements in the queue are after the clear method: " + queue1.Count);
            Console.ReadLine();

        }
    }
}

    