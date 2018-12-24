using System;

class X
{
    private int a;
    public int A { get => a; set => a = value; }
    public void Sub() => Console.WriteLine(a);
}

class Program
{
    static void Main()
    {
        var x = new X();
        x.A = 4649;
        x.Sub();
    }
}
