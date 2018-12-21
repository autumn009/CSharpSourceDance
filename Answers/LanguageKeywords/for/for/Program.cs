using System;

class Program
{
    static void Main()
    {
        bool j = true;
        for (int i = 0; j; i++)
        {
            if (i == 3) j = false;
            Console.Write(i);
        }
    }
}
