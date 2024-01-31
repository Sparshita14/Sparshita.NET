using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    internal class Program
    {
        public static void helloWorld(string hello, string world) { 
            Console.WriteLine("hello={0} world={1}", hello, world);
        }

        static void Main(string[] args)
        {
            helloWorld("hello", "world");
            helloWorld(hello: "world", "world");
            helloWorld("world", world: "hello");
            helloWorld(hello: "world", world:"hello");
            Console.ReadLine();

        }
    }
}
