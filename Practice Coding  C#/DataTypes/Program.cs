using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // sbyte
        sbyte a = -10;
        Console.WriteLine("sbyte...");
        Console.WriteLine("a = " + a);
        Console.WriteLine("type of variable = " + a.GetType());
        Console.WriteLine("size of sbyte = " + sizeof(sbyte));
        Console.WriteLine("Min value of sbyte = " +
        sbyte.MinValue);
        Console.WriteLine("Max value of sbyte = " +
        sbyte.MaxValue);
        Console.WriteLine();
       
        // Byte
        byte b = 10;
        Console.WriteLine("byte...");
        Console.WriteLine("b = " + b);
        Console.WriteLine("type of variable = " + b.GetType());
        Console.WriteLine("size of byte = " + sizeof(byte));
        Console.WriteLine("Min value of byte = " +
        byte.MinValue);
        Console.WriteLine("Max value of byte = " +
        byte.MaxValue);
        Console.WriteLine();

        //char
        char c = 'P';
        Console.WriteLine("char...");
        Console.WriteLine("c = " + c);
        Console.WriteLine("type of variable = " + c.GetType());
        Console.WriteLine("size of char = " + sizeof(char));
        Console.WriteLine("Min value of char = " + (int)
       (char.MinValue));
        Console.WriteLine("Max value of char = " + (int)
       (char.MaxValue));
        Console.WriteLine();

        //short
        short d = -18910;
        Console.WriteLine("short...");
        Console.WriteLine("d = " + d);
        Console.WriteLine("type of variable = " + d.GetType());
        Console.WriteLine("size of short = " + sizeof(short));
        Console.WriteLine("Min value of short = " +
       short.MinValue);
        Console.WriteLine("Max value of short = " +
       short.MaxValue);
        Console.WriteLine();

        //ushort
        ushort e = 18910;
        Console.WriteLine("ushort...");
        Console.WriteLine("e = " + e);
        Console.WriteLine("type of variable = " + e.GetType());
        Console.WriteLine("size of ushort = " + sizeof(short));
        Console.WriteLine("Min value of ushort = " +
       ushort.MinValue);
        Console.WriteLine("Max value of ushort = " +
       ushort.MaxValue);
        Console.WriteLine();

        //int
        int f = -893818910;
        Console.WriteLine("int...");
        Console.WriteLine("f = " + f);
        Console.WriteLine("type of variable = " + f.GetType());
        Console.WriteLine("size of int = " + sizeof(int));
        Console.WriteLine("Min value of int = " +
       int.MinValue);
        Console.WriteLine("Max value of int = " +
       int.MaxValue);
        Console.WriteLine();

        //uint
        uint g = 893818910;
        Console.WriteLine("uint...");
        Console.WriteLine("g = " + g);
        Console.WriteLine("type of variable = " + g.GetType());
        Console.WriteLine("size of uint = " + sizeof(uint));
        Console.WriteLine("Min value of uint = " +
       uint.MinValue);
        Console.WriteLine("Max value of uint = " +
       uint.MaxValue);
        Console.WriteLine();

        //long
        long h = -90909893818910;
        Console.WriteLine("long...");
        Console.WriteLine("h = " + h);
        Console.WriteLine("type of variable = " + h.GetType());
        Console.WriteLine("size of long = " + sizeof(long));
        Console.WriteLine("Min value of long = " +
       long.MinValue);
        Console.WriteLine("Max value of long = " +
       long.MaxValue);
        Console.WriteLine();

        //ulong
        ulong i = 90909893818910;
        Console.WriteLine("ulong...");
        Console.WriteLine("i = " + i);
        Console.WriteLine("type of variable = " + i.GetType());
        Console.WriteLine("size of ulong = " + sizeof(ulong));
        Console.WriteLine("Min value of ulong = " +
       ulong.MinValue);
        Console.WriteLine("Max value of ulong = " +
       ulong.MaxValue);
        Console.WriteLine();
   

        //decimal
        decimal ad = 45.3m;
        Console.WriteLine("decimal...");
        Console.WriteLine("ad = " + ad);
        Console.WriteLine("type of variable = " + ad.GetType());
        Console.WriteLine("size of decimal = " + sizeof(decimal));
        Console.WriteLine("Min value of decimal = " +
        decimal.MinValue);
        Console.WriteLine("Max value of decimal = " +
        decimal.MaxValue);
        Console.WriteLine();

        // bool
        bool bo = false;
        Console.WriteLine("boolean...");
        Console.WriteLine("bo = " + bo);
        Console.WriteLine("type of variable = " + bo.GetType());
        Console.WriteLine("size of decimal = " + sizeof(bool));
        Console.WriteLine();

        //variable declaration
        float num = 12345.6789f;
        Console.WriteLine("num: " + num);
        Console.WriteLine("Type of num: " + num.GetType());
        Console.WriteLine("Size of a float variable: " +
       sizeof(float));
        Console.WriteLine("Min value of float: " +
       float.MinValue);
        Console.WriteLine("Max value of float: " +
       float.MaxValue);

        double db = 12345.6789;
        Console.WriteLine("db: " + db);
        Console.WriteLine("Type of num: " + db.GetType());
        Console.WriteLine("Size of a double variable: " + sizeof(double));
        Console.WriteLine("Min value of double: " +double.MinValue);
        Console.WriteLine("Max value of double: " + double.MaxValue);

        Console.ReadLine();

    }
}

    