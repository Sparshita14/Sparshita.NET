using System;
using SparshitaCollection;
using SparshitaPalCollection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("collection implementing linked list");
            SparshitaCollection<int> myCollection = new SparshitaCollection<int>();


            myCollection.Add(1);
            myCollection.Add(2);

            foreach (int i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine(myCollection.IndexOf(0));
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("collection using double linked list");
            SparshitaPalCollection<string> mycoll = new SparshitaPalCollection<string>();
            mycoll.Add("hello");
            mycoll.Add("world");

            Console.WriteLine("adding");
            foreach (var i in mycoll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("fetching using []");
            Console.WriteLine(mycoll[0]);
            Console.WriteLine();

            mycoll.Insert(1, "this");
            Console.WriteLine("inserting at 1");
            foreach (var i in mycoll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            mycoll.RemoveAt(2);
            Console.WriteLine("removing at 2");
            foreach (var i in mycoll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            mycoll.Clear();
            Console.WriteLine("clearing");
            Console.WriteLine(mycoll.Count);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
