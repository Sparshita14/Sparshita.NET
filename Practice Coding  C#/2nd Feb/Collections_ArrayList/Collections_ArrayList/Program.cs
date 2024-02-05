using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayListClass cs = new ArrayListClass();
            cs.ArListMethod();
        }
    }

    public class ArrayListClass
    {
        /// <summary>
        /// this method implements ArrayList
        /// </summary>
        public void ArListMethod()
        {
            LotusCollection obj = new ArrayListClass();
            obj[0].

            List<int> l=new List<int> ();
            l[0] = 10;
            l.Add(20);

            ArrayList alist=new ArrayList();
      
            #region Adding Values in alist
            alist.Add(12);
            alist.Add("ArrayList");
            alist.Add('c');
            alist.Add(12.77f);
            alist.Add(1233.7m);
            #endregion

            #region Properties
            Console.WriteLine("Alist= {0}\nCapacity={1}\nCount={2} ",alist, alist.Capacity, alist.Count);

            Console.WriteLine("isFixedSize of alist= " + alist.IsFixedSize);
            Console.WriteLine("isReadOnly= " + alist.IsReadOnly);
            Console.WriteLine("isSynchronized= "+ alist.IsSynchronized);

           /* ArrayList alistfixed = ArrayList.FixedSize(alist);

            Console.WriteLine("isFixedSize of alistfixed= " + alistfixed.IsFixedSize);
            Console.WriteLine("capacity of alistfixed= "+alistfixed.Capacity);*/

            Console.WriteLine("alist value in 3rd pos= " + alist[3]);
            #endregion

            #region Iterating alist
            foreach (var i in alist)
            {
                Console.WriteLine(i);
            }
            #endregion

         /*   Console.WriteLine("clear");
            alist.Clear();*/

           /* Console.WriteLine("cloned");
            alist =(ArrayList)alistfixed.Clone();*/


            Console.WriteLine("contains= "+alist.Contains('c'));
            Console.WriteLine("contains= " + alist.Contains(567));

            #region array copy
            Object[] arr = alist.ToArray();
            Console.WriteLine("array copied");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion

           // Console.WriteLine("equals "+alist.Equals(alistfixed));

            Console.WriteLine("reverse");
            alist.Reverse();
            #region Iterating alist
            foreach (var i in alist)
            {
                Console.WriteLine(i);
            }
            #endregion

            alist.Add("remove");
            alist.Add("re-adding");

            Console.WriteLine("index of the item to delete "+ alist.IndexOf("remove"));
            int ind = alist.IndexOf("remove");
            alist.RemoveAt(alist.IndexOf("remove"));
            Console.WriteLine("item at ind= " + alist[ind]);

            String str = alist.ToString();
            Console.WriteLine("converting alist to string "+str);
            //output System.Collections.ArrayList

            Console.ReadLine();
        }
    }
}
