using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public class Program
    {
       public static void Main(string[] args)
        {
            PartialClass a =new PartialClass();
            a.method1();
            a.method2();
            int p = 1;
           //a.pmethod1(p);
            Console.ReadLine();
        }
    }
   
}
