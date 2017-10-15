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
            //find 'land'
            string[] array1 = Array.FindAll(Names,
               element => element.EndsWith("land",
               StringComparison.Ordinal));
            //find 'stan'
            string[] array2 = Array.FindAll(Names,
               element => element.EndsWith("stan",
               StringComparison.Ordinal));
            Console.WriteLine("Find 'land' : " + (string.Join(",", array1)));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Find 'stan' : " + (string.Join(",", array2)));
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


    