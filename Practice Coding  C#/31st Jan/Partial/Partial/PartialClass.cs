using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    
    public partial class PartialClass
    {
        
        int a;
        public void method1()
        {
            Console.WriteLine("first method");
        }
        partial void pmethod1(int a);
       /*partial void pmethod1(int a)
        {
            this.a = a;
            Console.WriteLine(a);
        }*/
    }
    public partial class PartialClass
    {
        
        public void method2()
        {
            pmethod1(1);
            Console.WriteLine("Second method");
        }
         partial void pmethod1(int a)
            {
                this.a=a;
            a++;
                Console.WriteLine(a);
            }


    }

}
