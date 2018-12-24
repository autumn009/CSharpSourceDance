using System;

class X
{
    public readonly int A;
    public X(int a) => A = a;
}

class Program
{
    static void Main()
    {
        var x = new X(4649);
        Console.WriteLine(x.A);
    }
}
