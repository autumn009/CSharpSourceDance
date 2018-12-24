using System;
using System.Linq;

class Program
{
    static void Sub(params int[] array)
    {
        Console.WriteLine($"sum is {array.Sum()}");
    }

    static void Main(string[] args)
    {
        Sub(1, 2, 3);
        Sub(4, 5);
    }
}
