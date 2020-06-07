using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem

            //Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            var x = 1020;
            var y = 120;

            Console.WriteLine(Calculate(x,y));
        }

        public static int Calculate(int x, int y)
        {
            if (x > y)
            {
                return (x - y) * 2;
            }
            else
            {
                return (y - x);
            }
        }
    }
}
