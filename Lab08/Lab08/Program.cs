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
            string[] Names = new string[]
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
            // C# program that uses LINQ
            var sortAscending = from Country in Names
                                orderby Country
                                select Country;
            var sortDescending = from Country in Names
                                 orderby Country descending
                                 select Country;
            Console.WriteLine("------String sort ascending----------");
            foreach (string c in sortAscending)
                Console.WriteLine(c);
            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);
            Console.ReadKey();
        }

    }
}


    