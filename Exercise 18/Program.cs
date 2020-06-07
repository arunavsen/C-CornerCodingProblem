using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = "";
            var g = new List<string>();
            Console.Write("Enter a line: ");
             var input = Console.ReadLine();

            var x = input.Split(' ');
            for (int i = x.Length; i >= 0; i--)
            {
                t = x[i] + " ";
                g.Add(t);
            }

            Console.Write("New line is: ");
            foreach (var l in g)
            {
                Console.Write(l);
            }

            Console.WriteLine();
        }
    }
}
