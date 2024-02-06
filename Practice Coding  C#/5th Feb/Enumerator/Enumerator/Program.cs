using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
   
    internal class Program
    {
        public static List<int> mylist = new List<int>();

        public static void filling()
        {
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);  
            mylist.Add(4);  
            mylist.Add(5);
        }
        static void Main(string[] args)
        {
            filling();
            foreach (var i in adding())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> adding()
        {
            int t = 0;
            foreach (int i in mylist)
            {
                t += i;
                yield return t;
            }
        }
    }
}
