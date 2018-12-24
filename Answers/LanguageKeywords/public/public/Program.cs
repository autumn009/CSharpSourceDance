using System;

public class A
{
    public void Sub() => Console.WriteLine("Everybody Welcome!");
}

class Program
{
    static void Main()
    {
        var a = new A();
        a.Sub();
    }
}
