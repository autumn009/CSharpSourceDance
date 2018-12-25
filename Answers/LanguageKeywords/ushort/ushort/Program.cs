using System;

class Program
{
    static void Main()
    {
        ushort a = 65534;
        ushort b = 1;
        ushort x = (ushort)(a + b);
        Console.WriteLine(x);
    }
}
