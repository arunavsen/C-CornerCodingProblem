using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = {1,2,3,4};
            int[] y = {1,2,3,4};
            Console.WriteLine("[{0}]",string.Join(",",x));
            Console.WriteLine("[{0}]", string.Join(",", y));

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] * y[i]+ " ");
            }
        }
    }
}
