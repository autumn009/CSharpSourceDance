using System;

class Program
{
    static void Sub(ref int a) => a++;

    static void Main()
    {
        int x = 4648;
        Sub(ref x);
        Console.WriteLine(x);
    }
}
