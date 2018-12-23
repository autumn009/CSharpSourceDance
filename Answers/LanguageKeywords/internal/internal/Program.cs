using System;

class Sample
{
    internal int X = 4649;
    private int Y = 4649;
    protected int Z = 4649;
}


class Program
{
    static void Main()
    {
        var a = new Sample();
        Console.WriteLine(a.X);
    }
}
