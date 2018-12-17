using System;

class Program
{
    static void Main()
    {
        int a = 4649;
        int b = 4649;
        bool c = a == b;
        if (c == true) Console.WriteLine("aはbと同じ");
        if (c) Console.WriteLine("aはbと同じ");
        if (c == false) Console.WriteLine("aはbと違う");
    }
}
