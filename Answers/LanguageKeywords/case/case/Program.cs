using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 0, 1, -1 };
        foreach (var item in array)
        {
            switch (item)
            {
                case 0: Console.Write("ZERO "); break;
                case 1: Console.Write("ONE "); break;
                default: Console.Write("MASQUERADE"); break;
            }
        }
    }
}
