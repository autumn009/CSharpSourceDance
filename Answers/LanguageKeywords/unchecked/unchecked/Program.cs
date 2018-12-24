using System;

    class Program
{
    static void Main()
    {
        unchecked
        {
            byte a = 255;
            a++;
            Console.WriteLine(a);
        }
    }
}

