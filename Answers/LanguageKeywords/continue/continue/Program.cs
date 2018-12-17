using System;

class Program
{
    static void Main()
    {
        const int x = 100;
        for (int i = -20; i <= 20; i += 10)
        {
            if (i == 0) continue;
            Console.WriteLine(x / i);
        }
    }
}
