using System;

sealed class A
{
    internal void Sub()
    {
        Console.WriteLine("Don't inherit A!");
    }
}

//class B : A { }

class Program
{
    static void Main()
    {
        var x = new A();
        x.Sub();
    }
}
