using System;

class Program
{
    static void Main()
    {
        unchecked
        {
            short a = short.MaxValue;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
        }
    }
}
