using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == 1 && j == 1) goto exit;
                Console.WriteLine($"{i}{j}");
            }
        }
        exit:
        Console.WriteLine("Done!");
    }
}
