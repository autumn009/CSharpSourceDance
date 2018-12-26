using System;

class Program
{
    static void Main()
    {
        var f = 1.0f;
        var a = (int)f;
        Console.WriteLine(a.GetType().FullName);
    }
}
