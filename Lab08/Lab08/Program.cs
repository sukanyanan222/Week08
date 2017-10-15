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
            int[] firstMonth = new int[12];
            int NumberOfMonth = 0;
            string DayName = "";
            firstMonth[0] = 0;    //January 
            firstMonth[1] = 3;    //February
            firstMonth[2] = 3;    //March 
            firstMonth[3] = 6;    //April  
            firstMonth[4] = 1;    //May  
            firstMonth[5] = 4;    //June
            firstMonth[6] = 6;    //July
            firstMonth[7] = 2;    //August
            firstMonth[8] = 5;    //September
            firstMonth[9] = 0;    //October
            firstMonth[10] = 3;   //November
            firstMonth[11] = 5;   //December
            Console.Write("Enter date : ");
            int date = int.Parse(Console.ReadLine());
            if (date >= 32)
            {
                Console.WriteLine("Error!, Please enter numbers 00 to 31 only.");
                goto lineOUT;
            }
            Console.Write("Enter month : ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 01:
                    NumberOfMonth = firstMonth[0];
                    break;
                case 02:
                    NumberOfMonth = firstMonth[1];
                    break;
                case 03:
                    NumberOfMonth = firstMonth[2];
                    break;
                case 04:
                    NumberOfMonth = firstMonth[3];
                    break;
                case 05:
                    NumberOfMonth = firstMonth[4];
                    break;
                case 06:
                    NumberOfMonth = firstMonth[5];
                    break;
                case 07:
                    NumberOfMonth = firstMonth[6];
                    break;
                case 08:
                    NumberOfMonth = firstMonth[7];
                    break;
                case 09:
                    NumberOfMonth = firstMonth[8];
                    break;
                case 10:
                    NumberOfMonth = firstMonth[9];
                    break;
                case 11:
                    NumberOfMonth = firstMonth[10];
                    break;
                case 12:
                    NumberOfMonth = firstMonth[11];
                    break;
                default:
                    Console.WriteLine("Error!, Please enter numbers 00 to 12 only.");
                    goto lineOUT;
            }
            int Ans = (date + NumberOfMonth - 1) % 7;
            switch (Ans)
            {
                case 0:
                    DayName = "Sunday";
                    break;
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                case 6:
                    DayName = "Saturday";
                    break;
            }
            Console.WriteLine("{0}/{1}/2560 is {2}.", date, month, DayName);
            lineOUT:
            Console.ReadKey();
        }

    }
}


    