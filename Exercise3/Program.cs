using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 3
            //Write a program that takes coordinates(x, y) of a center of a circle and its radius from the user, the program will determine whether a point lies inside the circle, on the circle or outside the circle.

            //formula (x-a)^2+(y-b)^2 = r^2
            //We have to take input of x and y and radius
            //Center point of the circle is (a,b)=(0,0)

            Console.WriteLine("Enter X coordinates of circle: ");
            var X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinates of circle: ");
            var Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter radius of circle: ");
            var radius = Convert.ToInt32(Console.ReadLine());

            var radiusCalculation = radius * radius;
            var coordinatesCalculation = X * X + Y * Y;

            if (coordinatesCalculation == radiusCalculation)
            {
                Console.WriteLine("Points lies on the circle");
            }
            else if (coordinatesCalculation > radiusCalculation)
            {
                Console.WriteLine("Points lies outside of the circle.");
            }
            else if (coordinatesCalculation < radiusCalculation)
            {
                Console.WriteLine("Points lies outside of the circle.");
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
            
        }
    }
}
