using System;

class A
{
    private int p;
    internal void Output() => Console.WriteLine(p);
    internal A(int p)
    {
        this.p = p;
    }
}

class Program
{
    static void Main()
    {
        var x = new A(4649);
        x.Output();
    }
}
