using System;

class Program
{
    static int Prop { get; set; }

    static void Main()
    {
        Prop = 4649;
        Console.WriteLine(Program.Prop);
    }
}
