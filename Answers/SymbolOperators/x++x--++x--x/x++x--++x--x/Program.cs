using System;

class Program
{
    static void Main()
    {
        int[] a = { 0, 1, 2, 3 };
        int p = 1;
        Console.WriteLine(a[p++]);
        Console.WriteLine(a[p]);
        Console.WriteLine(a[--p]);
    }
}
