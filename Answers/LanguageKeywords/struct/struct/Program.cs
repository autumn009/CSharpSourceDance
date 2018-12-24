using System;

struct A
{
    internal int X { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        a.X = 4648;
        A b = a;
        b.X++;
        Console.WriteLine(a.X);
        Console.WriteLine(b.X);
    }
}
