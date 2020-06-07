using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.Write("Give a number: ");
            var x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                var e = x % 10;
                sum = sum + e;
                x /= 10;
            }

            Console.WriteLine("Result: " + sum);
        }
    }
}
