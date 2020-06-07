using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    public class CompareClass
    {
        public bool Compare(string x, string y)
        {
            if (x.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Compare(int x, int y)
        {
            if (x.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class CClass<T>
    {
        public bool CCompare(T x, T y)
        {
            if (x.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Basics of generics
            //var t = new CompareClass();
            //var y = t.Compare(1, 2);
            //var z = t.Compare("Nick", "Nick");
            //Console.WriteLine(z);

            var w = new CClass<char>();
            Console.WriteLine(w.CCompare('e', 'e'));
            var n = new CClass<string>();
            Console.WriteLine(n.CCompare("nick","Nick"));
        }
    }
}
