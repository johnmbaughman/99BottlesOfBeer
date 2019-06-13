using System;

namespace _99BottlesOfBeer
{
    internal static class Program
    {
        static void Main()
        {
            int b = 99;

            while (b > 0)
            {
                Console.WriteLine($"{b} bottle{(b > 1 ? "s" : "")} of beer on the wall, {b} bottle{(b > 1 ? "s" : "")} of beer.");
                Console.WriteLine($"Take one down and pass it around, {(b == 1 ? "no more" : (b - 1).ToString())} bottle{(b - 1 == 1 ? "" : "s")} of beer on the wall.{Environment.NewLine}");
                b--;
            }

            Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer.{Environment.NewLine}Go to the store and buy some more, 99 bottles of beer on the wall.");
        }
    }
}
