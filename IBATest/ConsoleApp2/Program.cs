using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            MIncrement(ref i);
            Console.WriteLine(i);
        }

        static unsafe void MIncrement(ref int x)
        {
            x = x + 1;
        }
    }

}