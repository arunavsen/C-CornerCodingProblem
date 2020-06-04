using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Write a program using a for loop that prints the following series.1 2 4 8 16 21 64 128 …nth iteration

            Console.Write("Enter a value: ");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var result = Math.Pow(2, i);
                Console.Write(result +" ");
            }
            Console.WriteLine();
        }
    }
}
