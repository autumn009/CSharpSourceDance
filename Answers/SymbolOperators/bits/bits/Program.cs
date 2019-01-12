using System;

class Program
{
    static void Main()
    {
        int a = 1;
        int b = a | 2;
        int c = b & 2;
        int d = c ^ 1;
        Console.WriteLine(d);
    }
}
