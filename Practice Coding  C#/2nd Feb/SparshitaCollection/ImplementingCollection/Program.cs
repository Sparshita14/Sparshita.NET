using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SparshitaCollection;

namespace ImplementingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SparshitaCollection<int> myCollection = new SparshitaCollection<int>();
            myCollection.Add(1);
            myCollection.Add(2);

            foreach (int i in myCollection)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myCollection[0]);
            Console.ReadLine();
        }
    }
}
