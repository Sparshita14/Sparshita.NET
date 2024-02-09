using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Program
    {
        public static void  add(int b, int a = 1)
        {
            Console.WriteLine("b= {0} a={1}", b,a);
        }
        static void Main(string[] args)
        {
            add(2,3);
            Console.ReadLine();
            add(2);
            Console.ReadLine();

        }
    }
}
