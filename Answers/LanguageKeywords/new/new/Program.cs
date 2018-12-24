using System;

class A
{
    internal void Sub() => Console.WriteLine("In A");
}

class B:A
{
    internal new void Sub() => Console.WriteLine("In B");
}

class Program
{
    static void Main()
    {
        var x = new B();
        x.Sub();
    }
}
