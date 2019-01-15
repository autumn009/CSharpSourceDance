using System;

class X
{
    internal int Y;
}

class Program
{
    static void Main()
    {
        var a = new X();
        a.Y = 123;
        var b = new X();
        b.Y = 456;
        a = b;
        Console.WriteLine(a.Y);
    }
}
