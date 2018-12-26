using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var q = from n in array where n >= 3 && n <= 6 select n * 10;
        foreach (var item in q) Console.WriteLine(item);
    }
}
