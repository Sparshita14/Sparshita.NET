using System;

    class Program
    {
        enum colors { red=10, GREEN=76, BLUE , PINK=1};
        static void Main(string[] args)
        {
            Console.WriteLine("Red: {0}", (int)colors.red);
            Console.WriteLine("Green: {0}", (int)colors.GREEN);
            Console.WriteLine("Blue: {0}", (int)colors.BLUE);
            Console.WriteLine("pink: {0}", (int)colors.PINK);
        Console.ReadLine();
        }
    }

