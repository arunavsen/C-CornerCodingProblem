using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Write a program that takes a character from the user and determines whether the character entered is a capital letter, a small case letter, a digit or a special symbol. The following table shows the range of ASCII values for various characters.

            Console.Write("Enter a char: ");
            var input = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());

            int u = input;

            if (u >=65 && u<=90)
            {
                Console.WriteLine("Capital Letter"); 
            }else if (u>=97 && u<=122)
            {
                Console.WriteLine("Small Letter");
            }else if (u>=48 && u<=57)
            {
                Console.WriteLine("Digit");
            }
            else if (u == 0 && u <= 47 || u >= 58 && u <= 64 || u >= 91 && u <= 96 || u >= 123 && u <= 127)
            {
                Console.WriteLine("Special Char");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
        }
    }
}
