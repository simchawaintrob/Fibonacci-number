using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var fib = new Fibonacci();

            Console.WriteLine("get length of fibonacci series");
            Stopwatch watch = Stopwatch.StartNew();

            var length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}] ",fib.CalculateFibonacci(i));
            }
            watch.Stop();
            Console.WriteLine();
            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("recursively..");

            watch = Stopwatch.StartNew();
            for (int i = 0; i < length; i++)
            {
                Console.Write("[{0}] ", fib.CalculateFibonacciRecursive(i));
            }
            watch.Stop();
            Console.WriteLine();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);

            Console.ReadKey();
        }
    }
}
