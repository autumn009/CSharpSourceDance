using System;

class Program
{
    static Action sub(Action action)
    {
        return () =>
        {
            Console.Write("Hello ");
            action();
        };
    }

    static void Main()
    {
        var fullaction = sub(() =>
        {
            Console.Write("World!");
        });
        Console.Write("Let's say '");
        fullaction();
        Console.WriteLine("'");
    }
}
