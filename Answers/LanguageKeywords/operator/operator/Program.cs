using System;

class XY
{
    public int x { get; set; }
    public int y { get; set; }

    public static XY operator +(XY a, XY b)
    {
        var xy = new XY();
        xy.x = a.x + b.x;
        xy.y = a.y + b.y;
        return xy;
    }
}

class Program
{
    static void Main()
    {
        var p = new XY() { x = 1, y = 2 };
        var q = new XY() { x = 3, y = 4 };
        var r = p + q;
        Console.WriteLine($"r=({r.x},{r.y})");
    }
}
