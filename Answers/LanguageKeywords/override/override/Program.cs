using System;

abstract class A
{
    abstract internal void Sub();
}

class B : A
{
    internal override void Sub()
    {
        Console.WriteLine("I'm implemented!");
    }
}

class Program
{
    static void Main()
    {
        A a = new B();
        a.Sub();
    }
}
