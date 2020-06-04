using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Write a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.

            Console.Write("Enter year: ");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input % 4 == 0 ? "This is leap year" : "This is not leap year.");
        }
    }
}
