using System;

class A
{
    protected void subA()
    {
        Console.WriteLine("SubA");
    }
}

class B:A
{
    internal void SubB()
    {
        subA();
    }
}

class Program
{
    static void Main()
    {
        var x = new B();
        x.SubB();
    }
}
