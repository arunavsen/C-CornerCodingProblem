using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Write a program using a loop that prints the following output. 1 2 2 3 3 3 4 4 4 4 5 5 5 5 5 6 6 6 6 6 6. . .nth iteration.

            Console.Write("Enter a value: ");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }
        }
    }
}
