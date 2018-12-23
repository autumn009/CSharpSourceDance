using System;

interface ISample
{
    void Sub();
}

class X : ISample
{
    public void Sub()
    {
        Console.WriteLine("I'm in X!");
    }
}

class Program
{
    static void Main()
    {
        ISample a = new X();
        a.Sub();
    }
}
