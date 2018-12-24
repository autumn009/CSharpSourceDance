using System;

class Program
{
    private static void sub(out int x, out int y)
    {
        x = 4649;
        y = 4989;
    }

    static void Main()
    {
        int x, y;
        sub(out x, out y);
        Console.WriteLine($"x={x} y={y}");
    }
}
