using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("Arunav"));
        }
        public static string first_last(string ustr)
        {
            string e = "";
            if (ustr.Length > 1)
            {
                var y = ustr.Substring(1, ustr.Length - 2);
                var t = ustr.Substring(ustr.Length - 1);
                var c = ustr.Substring(0, 1);

                e = t + y + c;
            }

            return e;

           
        }
    }
}
