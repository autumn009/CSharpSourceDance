using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var q = from n in Enumerable.Range(1, 3) select n;
        foreach (var item in q) Console.Write(item);
    }
}
