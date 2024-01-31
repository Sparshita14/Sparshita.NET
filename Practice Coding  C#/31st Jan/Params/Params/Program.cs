using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        public static void paramsArray(params int[] num)
        {
            foreach (int i in num)
            {
                Console.WriteLine("num=>" + i);
            }
            
        }
        static void Main(string[] args)
        {
            paramsArray(1, 2, 3, 4);
            Console.ReadLine();
        }
    }
}
