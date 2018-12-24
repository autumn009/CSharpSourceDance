using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new Exception();
        }
        catch(Exception)
        {
            Console.WriteLine("catch");
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
}

