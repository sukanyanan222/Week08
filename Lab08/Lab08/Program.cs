using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("************");
            stack1.Push("RED");
            stack1.Push("GREEN");
            stack1.Push("BLUE");
            stack1.Push("YELLOW");
            stack1.Push("***********");
            stack1.Push("** COLOR **");
            stack1.Push("***********");
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            stack1.Clear();
            Console.WriteLine("After apply the clear method the elements in thestack are: " + stack1.Count);
            Console.ReadLine();

        }
    }
}

    