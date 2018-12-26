using System;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<int> getIt()
    {
        int n = 1;
        for (; ; )
        {
            yield return n;
            n *= 2;
            if (n > 100) yield break;
        }
    }


    static void Main()
    {
        foreach (var item in getIt()) Console.Write($"{item} ");
    }
}
