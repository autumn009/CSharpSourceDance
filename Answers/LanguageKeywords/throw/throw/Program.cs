using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new DivideByZeroException();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
