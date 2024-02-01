using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ref as a Parameter
            int a = 1;
            int b = 2;

            Console.WriteLine("before a->"+a);
            Console.WriteLine("befor b->" + b);

            adding(a);
            subracting(ref b);

            Console.WriteLine("after a->" + a);
            Console.WriteLine("after b->" + b);
           

            // out as Parameter

            int i=10;
            int val ;
            Addition(out i);
            bool boo = int.TryParse("10", out val); ;
            Console.WriteLine("boolean for tryparse "+boo);
            Console.WriteLine("value i after method->" + i);

            String t = "10";
            t.ToInt();
            Console.Read();
        }
        public static void adding(int a)
        {
            a++;
            Console.WriteLine("value a in method->"+a);
        }

        public static void subracting(ref int b)
        {
            //b = 10;
            b++;
            Console.WriteLine("value b  in method->" + b);
        }

        // out method
        public static void Addition(out int i)
        {
            i = 10;
            i++;
            Console.WriteLine("value i in method->" + i);
            
        }
    }
}
