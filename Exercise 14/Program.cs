using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem

            //Write a C# program to find the longest word in a string.
            var largest = "";
            var count = 0;

            Console.Write("Enter a line: ");
            var input = Console.ReadLine();

            var y = input.Split(' ');
            foreach (var x in y)
            {
                if (x.Length >= count)
                {
                    largest = x;
                    count = x.Length;
                }
            }

            Console.Write("Largest word is: "+ largest);
            Console.ReadKey();
        }
    }
}
