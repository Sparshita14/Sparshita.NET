using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 19;
            int sol = num.addingOne(num);

            Console.WriteLine("num before-> " + num);
            Console.WriteLine("after extension-> " + sol);
            Console.ReadLine();

            // nullable
            int? j = null;
            Console.WriteLine("nullable int-> " + j);
            Console.ReadLine();

        }
    }
    public static class IntExe
    {
        /// <summary>
        /// This method is used to add 1 to the number
        /// </summary>
        /// <param name="a"> the input number for adding 1</param>
        /// <returns>return number incremented by 1</returns>
        public static int addingOne(this int i, int a)
        {
            return a++;
        }
    }
}
}
