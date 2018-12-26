using System;

partial class A
{
    internal void Sub1() => Console.WriteLine("I'm Sub1");
}

partial class A
{
    internal void Sub2() => Console.WriteLine("I'm Sub2");
}

class Program
{
    static void Main()
    {
        var a = new A();
        a.Sub1();
        a.Sub2();
    }
}
