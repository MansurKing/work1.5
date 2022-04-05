using System;

namespace work1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
