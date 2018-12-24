using System;

class Program
{
    static void Main()
    {
        object[] array = { 1, 2, "Three", 4 };
        int sum = 0;
        foreach (var item in array)
        {
            if (item is int) sum += (int)item;
        }
        Console.WriteLine(sum);
    }
}


