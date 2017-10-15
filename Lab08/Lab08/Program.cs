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
            double[] GPS = new double[8];
            double GPA = 0;
            for (int i = 0; i < GPS.Length; i++)
            {
                Console.Write("Enter grade on semester {0} : ", i + 1);
                GPS[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------a---------------");
            for (int i = 0; i < GPS.Length; i++)
            {
                Console.WriteLine("Grade on semester {0} : {1}", i + 1, GPS[i]);
            }
            Console.WriteLine("--------------b---------------");
            for (int i = 0; i < GPS.Length; i++) { GPA += GPS[i]; }
            Console.WriteLine("GPA is : " + GPA / GPS.Length);
            Console.ReadKey();

        }
    }
}

    