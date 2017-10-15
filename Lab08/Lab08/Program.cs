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
            //find "land"
            string[] ArrayA = Array.FindAll(Names, element => element.EndsWith("land",
                      StringComparison.Ordinal));
            string[] ArrayB;
            //find "stan"
            string[] ArrayC = Array.FindAll(Names, element => element.EndsWith("stan",
                      StringComparison.Ordinal));
            string[] ArrayD;
            // copy by operator =
            ArrayB = ArrayA;
            ArrayD = ArrayC;

            Console.WriteLine("*** Array copy by operator = ***");
            Console.WriteLine("===== Countrys =====");
            for (int i = 0; i < Names.Length; i++)
            { Console.WriteLine("Country[{0}] = {1}", i + 1, Names[i]); }
            Console.WriteLine("--------------------");
            Console.WriteLine("Find 'land' : " + (string.Join(", ", ArrayB)));
            Console.WriteLine("Find 'stan' : " + (string.Join(", ", ArrayD)));
            Console.ReadKey();
        }
        public static string[] Names = new string[]
        {
    "Afghanistan",
    "Albania",
    "Algeria",
    "American Samoa",
    "Andorra",
       
    "Virgin Islands, British",
    "Virgin Islands, US",
    "Wallis and Futuna",
    "Western Sahara",
    "Yemen",
    "Zambia",
    "Zimbabwe",
        };
    }

}
       