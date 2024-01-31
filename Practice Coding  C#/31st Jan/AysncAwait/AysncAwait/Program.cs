using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            starting();
            Console.ReadLine();
        }
        public static async void starting()
        {
            var watch= new System.Diagnostics.Stopwatch();
            watch.Start();
            //var t1 = StartFirst();
            // await t1;
            var t2= StartSecond();
            //await t2;
            var t1 = StartFirst();
            var t3=StartThird();
            //await t3;
            Task.WaitAll(t1, t2, t3);
            watch.Stop();
            Console.WriteLine($"Execution Time:   { watch.ElapsedMilliseconds} ms"); 


        }
        public static async Task StartFirst()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine("first");
            });
        }
        public static async Task StartSecond()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("second");
            });
        }
        public static async Task StartThird()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("third");
            });
        }
    }
}
