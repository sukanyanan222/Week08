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
                int n = 1;
                Dictionary<string, string> dict1 = new Dictionary<string, string>();
                dict1.Add("txt", "Notepad.exe");
                dict1.Add("bmp", "paint.exe");
                dict1.Add("rtf", "wordpad.exe");
                dict1.Add("pdf", "acrobat.exe");
                Console.WriteLine("======File type======");
                foreach (var item in dict1)
                {
                    Console.WriteLine("{1}. {0}", item.Key, n);
                    n++;
                }
                Console.Write("Choose your file type(1-4) : ");
                int F = int.Parse(Console.ReadLine());
                switch (F)
                {
                    case "txt":
                        Console.WriteLine("txt files must be enabled for Notepad.exe.");
                        break;
                    case "bmp":
                        Console.WriteLine("bmp files must be enabled for paint.exe.");
                        break;
                    case "rtf":
                        Console.WriteLine("rtf files must be enabled for wordpad.exe.");
                        break;
                    case "pdf":
                        Console.WriteLine("pdf files must be enabled for acrobat.exe.");
                        break;
                    default:
                        Console.WriteLine("Error! You entered incorrect information.");
                        break;
                }
                Console.ReadKey();

            }
        }
}

    