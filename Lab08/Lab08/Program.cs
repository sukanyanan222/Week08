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
            //find "ber"
            string[] ArrayA = Array.FindAll(Names, element => element.EndsWith("ber",
                         StringComparison.Ordinal));
            string[] ArrayB;
            //find "ry"
            string[] ArrayC = Array.FindAll(Names, element => element.EndsWith("ry",
                         StringComparison.Ordinal));
            string[] ArrayD;
            // copy by operator =
            ArrayB = ArrayA;
            ArrayD = ArrayC;
            Console.WriteLine("*** Array copy by operator = ***");
            Console.WriteLine("===== Months =====");
            for (int i = 0; i < Names.Length; i++)
            { Console.WriteLine("Month[{0}] = {1}", i + 1, Names[i]); }
            Console.WriteLine("--------------------");
            Console.WriteLine("Find 'ber' : " + (string.Join(", ", ArrayB)));
            Console.WriteLine("Find 'ry'  : " + (string.Join(", ", ArrayD)));
            Console.ReadKey();
        }
        public static string[] Names = new string[]
        {"January","February","March","April","May","June","July","August","September","October","November","December"};

    }
}


    