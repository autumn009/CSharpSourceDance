using System;

class A
{
    private int a { get; set; } = 1;
    public int b { get; set; } = 2;
    public void sub()
    {
        Console.WriteLine(a + b);
    }
}

class Program
{
    static void Main()
    {
        var a = new A();
        a.b = 999;
        a.sub();
    }
}
