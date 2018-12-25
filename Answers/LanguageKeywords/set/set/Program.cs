using System;

class Program
{
    private static int prop;
    static int Prop
    {
        get { return prop; }
        set { prop = value; }
    }

    static void Main()
    {
        Prop = 4649;
        Console.WriteLine(Prop);
    }
}
