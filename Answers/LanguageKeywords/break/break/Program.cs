using System;

class Program
{
    static void Main()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (j == 1 && i == 1) break;
                Console.Write($"{i}+{j}={i+j} ");
            }
            Console.WriteLine();
        }
    }
}
