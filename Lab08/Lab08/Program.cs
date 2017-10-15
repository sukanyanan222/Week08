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
                int[] ArrayA = new int[] { 1, 2, 3, 4, 5, 6 };
                int[] ArrayB = new int[6];
                // copy by operator =
                ArrayB = ArrayA;

                Console.WriteLine("*** Array copy by operator = ***");
                Console.WriteLine("===== Before =====");
                for (int i = 0; i < ArrayA.Length; i++)
                {
                Console.WriteLine("arrayA[{0}] = {1},");
                    ArrayB [{ 0}] = { 2}
                    ",i, ArrayA[i], ArrayB[i]);
                }
                // change element 0 of ArrayA
                ArrayA[0] = 9;
                Console.WriteLine("===== After ======");
                for (int i = 0; i < ArrayA.Length; i++)
                {
                    Console.WriteLine("ArrayA[{0}] = {1}, 
    
                      ArrayB[{ 0}] = { 2}
                    ", i, ArrayA[i], ArrayB[i]);
                }

                // copy by method Array.Copy()
                int[] ArrayC = new int[6];
                Array.Copy(ArrayA, ArrayC, ArrayA.Length);

                Console.WriteLine("*** Array copy by method Array.Copy() ***");
                Console.WriteLine("===== Before =====");
                for (int i = 0; i < ArrayA.Length; i++)
                {
                    Console.WriteLine("ArrayA[{0}] = {1}, 
    
                      ArrayC[{ 0}] = { 2}
                    ", i, ArrayA[i], ArrayC[i]);
                }
                // change element 0 of ArrayA
                ArrayA[0] = 1;
                Console.WriteLine("===== After =====");
                for (int i = 0; i < ArrayA.Length; i++)
                {
                    Console.WriteLine("ArrayA[{0}] = {1}, 
    
                      ArrayC[{ 0}] = { 2}
                    ", i, ArrayA[i], ArrayC[i]);
                }

                // wait
                Console.ReadLine();
            }
    }
}


    