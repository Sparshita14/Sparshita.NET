﻿using System;
namespace Delegates
{

    class Class1
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        public static void Main(String[] args)
        {

            Class1 obj = new Class1();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);
            del_obj1(100, 40);
            del_obj2(100, 60);

          
            Console.ReadLine();

        }
    }
}
