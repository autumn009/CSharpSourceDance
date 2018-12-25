using System;

class A
{
    internal virtual void Sub()
    {
        Console.WriteLine("A.Sub();");
    }
}

class B:A
{
    internal override void Sub()
    {
        Console.WriteLine("B.Sub();");
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
