using System;

class Program
{
    static void Main()
    {
        try
        {
            return;
        }
        finally
        {
            Console.WriteLine("Bye Bye!");
        }
        Console.WriteLine("Hello!");
    }
}
