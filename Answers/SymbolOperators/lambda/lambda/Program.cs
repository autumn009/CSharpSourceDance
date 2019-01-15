using System;

class Program
{
    static void Main()
    {
        Action action = () => Console.WriteLine("Hello from Lambda!");
        action();
    }
}
