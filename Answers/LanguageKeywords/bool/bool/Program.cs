using System;

class Program
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        bool x = a == b;
        if (x == true) Console.WriteLine("aとbは同じです。");
        if (x == false) Console.WriteLine("aとbは異なります。");
    }
}
