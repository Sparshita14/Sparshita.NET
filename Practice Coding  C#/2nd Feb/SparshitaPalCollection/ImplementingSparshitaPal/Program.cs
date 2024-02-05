using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SparshitaPalCollection;

namespace ImplementingSparshitaPal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SparshitaPalCollection<int> mycoll = new SparshitaPalCollection<int>();
            mycoll.Add(100);
            mycoll.Add(87);

            Console.WriteLine("adding");
            foreach (var i in mycoll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("fetching using []");
            Console.WriteLine(mycoll[0]);
            Console.WriteLine();

            mycoll.Insert(1, 178);
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
