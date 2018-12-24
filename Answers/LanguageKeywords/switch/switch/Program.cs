using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            switch (i)
            {
                case 0: Console.Write("ZERO "); break;
                case 1: Console.Write("ONE "); break;
                case 2: Console.Write("TWO "); break;
                default: Console.WriteLine("? "); break;
            }
        }
    }
}
