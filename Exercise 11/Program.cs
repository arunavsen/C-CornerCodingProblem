using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        public string remove(string x, int y)
        {
            return x.Remove(y);
        }
        static void Main(string[] args)
        {
            var f = "w3resource";
            Console.WriteLine(f.Remove(9));
        }
    }
}
