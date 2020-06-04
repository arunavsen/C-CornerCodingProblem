using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question:
            //Write a program that converts 1 lower case letter("a" - "z") to its corresponding upper case letter("A" - "Z").For example if the user enters "c" then the program will show "C" on the screen.
            
            int b;
            Console.WriteLine("Enter a letter between a - z: ");
            var input = Convert.ToChar(Console.ReadLine());
            b = input;

            Console.WriteLine("Ans: "+ input.ToString().ToUpper());

            Console.ReadLine();
        }
    }
}
