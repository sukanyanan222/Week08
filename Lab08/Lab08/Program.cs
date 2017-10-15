using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
            static void Main(string[] args)
            {
                int[] data = new int[10];
                int temp = 0;
                for (int i = 0; i < data.Length; i++) { data[i] = i; }
                Console.WriteLine("data[7] : " + data[7]);
                Console.WriteLine("data[4] + data[9] : " + (data[4] + data[9]));
                Console.WriteLine("data[2] == data[6] ? : " + (data[2] == data[6] ? "equal" : "not equal"));
                for (int i = 0; i < data.Length; i++) { temp += data[i]; }
                Console.WriteLine("Sum : " + temp);
                Console.Write("All values : ");
                for (int i = 0; i < data.Length; i++) { Console.Write(data[i] + " "); }
                Console.ReadLine();
            }

    }
}

    