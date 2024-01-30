using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        Object o1 = a;
        Object o2 = o1;
        Console.WriteLine("a= "+a);
        Console.WriteLine("o1= " + o1);
        Console.WriteLine("o2= " + o2);
        Console.WriteLine("o1 type " + o1.GetType());
        o1 = 10f;
        Console.WriteLine("a= " + a);
        Console.WriteLine("o1= " + o1);
        Console.WriteLine("o2= " + o2);
        Console.WriteLine("o1 type " + o1.GetType());
        Console.WriteLine("o2 type " + o2.GetType());
        //Console.WriteLine("f= " + f);


    }
}