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
            int[,] multiplyTable = new int[12, 12];
            for (int i = 0, table = 2; i < multiplyTable.GetLength(0); i++, table++)
            {
                for (int j = 0; j < multiplyTable.GetLength(1); j++)
                {
                    multiplyTable[j, i] = table * (j + 1);
                }
            }
            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                    Console.Write("{0,5}", multiplyTable[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

    