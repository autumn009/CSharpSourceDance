using System;
using System.Linq;

class Program
{
    static void Main()
    {
        foreach (var item in Enumerable.Range(0, 3).Reverse())
        {
            Console.Write(item);
        }
    }
}
