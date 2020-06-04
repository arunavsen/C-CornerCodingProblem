using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            //Write a program that takes three points(x1, y1), (x2, y2) and(x3, y3) from the user and the program will check wheteher or not all the three points fall on one straight line.

            int x1, x2, x3, y1, y2, y3;
            int slope1, slope2, slope3;

            Console.WriteLine("Enter the value of x1 and y1 coordinates of first point: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2 and y2 coordinates of second point: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x3 and y3 coordinates of third point: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            slope1 = y2 - y1 / x2 - x1;
            slope2 = y3 - y2 / x3 - x2;
            slope3 = y3 - y1 / x3 - x1;

            if (slope1 == slope2 && slope3 == slope2)
            {
                Console.WriteLine("All the three points fall on one straight line.");
            }
            else
            {
                Console.WriteLine("It is not a straight line.");
            }
        }
    }
}
