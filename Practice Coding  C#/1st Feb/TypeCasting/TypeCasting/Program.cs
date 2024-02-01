using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypeCasting
{
    class Program
    {


        static void Main(string[] args)
        {
            // implicit type conversion
            #region Implictdeclaration
            byte b = 23;
            short s = b;
            int i = b;
            long l = i;
            float f = l;
            double d = f;
            #endregion

            Console.WriteLine("short-> " + s);
            Console.WriteLine("int-> " + i);
            Console.WriteLine("long-> " + l);
            Console.WriteLine("float-> " + f);
            Console.WriteLine("double-> " + d);
            Console.ReadLine();

            char c = 'c';
            int i1 = c;
            long l1 = i1;
            float f1 = l1;
            double d1 = f1;
            Console.WriteLine("char-> " + c);
            Console.WriteLine("int-> " + i1);
            Console.WriteLine("long-> " + l1);
            Console.WriteLine("float-> " + f1);
            Console.WriteLine("double-> " + d1);
            Console.ReadLine();

            // Explicit type conversion

            #region Explict
            decimal m = 12.3333m;
            double dl = (double)m;
            float fl = (float)m;
            long lg = (long)m;
            int val = (int)m;
            byte by = (byte)dl;
            #endregion


            Console.WriteLine("decimal-> " + m);
            Console.WriteLine("double-> " + dl);
            Console.WriteLine("float-> " + fl);
            Console.WriteLine("long-> " + lg);
            Console.WriteLine("int-> " + val);
            Console.WriteLine("byte-> " + by);
            Console.ReadLine();

            
            string str = "10";
            int op = str.IntAdOne(str);
            Console.WriteLine("str-> " + str);
            Console.WriteLine("op-> "+op);
            Console.ReadLine();
        }



    }
    public static class Exe
    {
        /// <summary>
        /// This method is used to add 1 to the given variable
        /// </summary>
        /// <param name="qp">this is input parameter</param>
        /// <returns>input parameter with +1</returns>
        public static int IntAdOne(this string zt, string qp)
        {
            return Convert.ToInt32(qp);
        }
    }
}

