using System;

class Program
{
    private static bool sub2()
    {
        Console.WriteLine("In sub2");
        return false;
    }

    private static bool sub1()
    {
        Console.WriteLine("In sub1");
        return true;
    }
    static void Main()
    {
        if (sub1() || sub2()) Console.WriteLine("Nice Day!");
        if (sub2() && sub1()) Console.WriteLine("Good Day!");
    }
}
