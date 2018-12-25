using System;

class Program
{
    static void Sub1()
    {
        Console.WriteLine("In Sub1");
    }

    static int Sub2()
    {
        Console.WriteLine("In Sub2");
        return 4849;
    }

    static void Main()
    {
        Sub1();
        Sub2();
    }
}
