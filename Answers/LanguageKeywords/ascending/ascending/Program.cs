using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 3, 1, 2 };
        foreach (var item in from n in array orderby n ascending select n) Console.Write(item);
    }
}
