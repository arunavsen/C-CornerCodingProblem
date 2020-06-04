using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 5
            //Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion.If user enters:

            //I->convert from inches to centimeters.
            //G->convert from gallons to liters.
            //M->convert from mile to kilometer.
            //P->convert from pound to kilogram.

            //If the user enters any other character then show a proper message.


            var charbray = new List<char>();
            charbray.Add('I');
            charbray.Add('G');
            charbray.Add('M');
            charbray.Add('P');

            Console.Write("Enter a value: ");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nI->convert from inches to centimeters." +
                              "\nG->convert from gallons to liters. " +
                              "\nM->convert from mile to kilometer." +
                              "\nP->convert from pound to kilogram.\n");
            var choice = Convert.ToChar(Console.ReadLine()?.ToUpper() ?? throw new InvalidOperationException());

            if (charbray.Contains(choice))
            {
                switch (choice)
                {
                    case 'I':
                        var t = input * 2.54;
                        Console.WriteLine("Centimeter: " + t + "\n[INCH to CM]");
                        break;
                    case 'G':
                        var x = input * 3.78541;
                        Console.WriteLine("Liter: " + x + "\n[GALLON to LITER]");
                        break;
                    case 'M':
                        var h = input * 1.60934;
                        Console.WriteLine("Kilometer: " + h + "\n[MILE to KM]");
                        break;
                    case 'P':
                        var p = input * 0.453592;
                        Console.WriteLine("Centimeter: " + p + "\n[POUND to KM]");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
