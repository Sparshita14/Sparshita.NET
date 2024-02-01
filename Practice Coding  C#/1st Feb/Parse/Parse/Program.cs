using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "10";

            // using Parse to change string to int
            int num=int.Parse(s);
            Console.WriteLine("int num value= {0}, num data type= {1}", num, num.GetType());
            byte bt=byte.Parse(s);
            Console.WriteLine("byte bt value= {0}, bt data type= {1}", bt, bt.GetType());
            Console.ReadLine();

            //using try Parse
            int i;
            bool bl = int.TryParse("23", out  i);
            Console.WriteLine("can be chnages-> " + bl);
            Console.WriteLine("can be changes-> " + i);
            Console.ReadLine();

            int i2;
            bool bl2 = int.TryParse("10f", out i2);
            Console.WriteLine("can be chnages-> " + bl2);
            Console.WriteLine("can be chnages-> " + i2);
            Console.ReadLine();


            uint num2 = uint.MaxValue;

            unchecked
            {
                Console.WriteLine(num2 + 3);  // output: 2
            }

           
                checked
                {
                    Console.WriteLine(num2 + 3);
                }
            
            Console.ReadLine();





        }
    }
}
