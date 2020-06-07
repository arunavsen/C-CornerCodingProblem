using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = "";

            Console.WriteLine("Enter a word: ");
            var t = Console.ReadLine();

            if (t.Length > 1)
            {
                var h = t.Substring(0, 1);
                f = h + t + h;
            }

            Console.WriteLine(f);
        }
    }
}
