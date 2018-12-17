using System;

enum YesNo
{
    Yes,
    No
}

class Program
{
    static void Main()
    {
        YesNo x = YesNo.No;
        x--;
        Console.WriteLine(x);
    }
}
