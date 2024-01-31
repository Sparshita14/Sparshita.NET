using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            A a=new A();
            a.m1();
            a.m2();
           // a.m12();
            Console.ReadLine();
        }
    }
    public partial class A
    {
        public  void m1()
        {
            Console.WriteLine("first method");
        }
        // partial void m12(int a) { }
    }
    public partial class A
    {
        public  void m2()
        {
            Console.WriteLine("Second method");
        }
       /* partial void m12(int a) {
            Console.WriteLine("a");
        }*/


    }
}
