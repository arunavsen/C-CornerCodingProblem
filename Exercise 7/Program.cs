using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Write a program that prints an identity matrix using a for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            Console.Write("Enter the size of the identity matrix: ");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(i == j ? "1" : "0");
                }
                Console.Write("\n");
            }
        }
    }
}
