using System;

class A
{
    internal static int X { get; set; }
    internal void Sub(int x) => X = x;
    internal void Output() => Console.WriteLine(X);
}

class Program
{
    static void Main()
    {
        var p = new A();
        var q = new A();
        p.Sub(1);
        q.Sub(2);
        p.Output();
    }
}
