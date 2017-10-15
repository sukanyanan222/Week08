using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable weeks = new Hashtable();
            weeks.Add("1", "SunDay");
            weeks.Add("2", "MonDay");
            weeks.Add("3", "TuesDay");
            weeks.Add("4", "WednesDay");
            weeks.Add("5", "ThursDay");
            weeks.Add("6", "FriDay");
            weeks.Add("7", "SaturDay");

            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }
            Console.ReadLine();
        }
    }
}

    