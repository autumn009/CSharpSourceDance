using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        list[7] = 4649;
        list.Insert(0, -1);
        Console.WriteLine(list[8]);
    }
}
