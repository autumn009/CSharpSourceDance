using System;

class Program
{
    static void Main()
    {
        bool a = true;
        bool b = !a;
        bool c = !b;
        Console.WriteLine(a == c);
    }
}
