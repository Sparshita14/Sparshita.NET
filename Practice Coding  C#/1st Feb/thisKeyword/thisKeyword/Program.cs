using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisKeyword
{

    // this used to refer class instant method
    // this is used to invoke method
    // this is used to invoke constructor method
    // used delcare indexer
    public class keywrd
    {
        public int val;
        private int[] hr = new int[3];

        public int this[int index]
        {
            get
            {
                return hr[index];
            }
            set
            {
                hr[index] = value;
            }
        }
        public keywrd():this(66) {
            Console.WriteLine("non parameter constructor");
            Console.ReadLine();

        }
        public keywrd(int i)
        {
            Console.WriteLine("parameter constructor "+i);
        }

        public int getval()
        {
            return val;
        }
        public void setval(int val)
        {
            this.val = val;
        }

        public void hello()
        {
            Console.WriteLine("hello");
        }

        public void world()
        {
            this.hello();
            Console.WriteLine("world");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            keywrd key = new keywrd();
            key.setval(234);
            Console.WriteLine("this used to refer class instant method");
            Console.WriteLine(key.getval());    
            Console.ReadLine();

            Console.WriteLine("this is used to invoke method");
            key.world();
            Console.ReadLine();


            Console.WriteLine("this is used delcare indexer");
            key[0] = 1;
            key[1] = 2;
            key[2] = 3;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(key[i]);
            }
            Console.ReadLine();
        }
    }
}
