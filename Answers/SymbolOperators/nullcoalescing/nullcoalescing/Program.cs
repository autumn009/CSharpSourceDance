using System;

class Program
{
    static void Main()
    {
        int? x = null;
        var y = x ?? 4649;
        Console.WriteLine(y);
    }
}
