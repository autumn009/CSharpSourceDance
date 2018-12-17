using System;

    class Program
{
    static void Main()
    {
        int a = int.MaxValue;
        int b = 1;
        try
        {
            Console.WriteLine(a + b);
            checked
            {
                Console.WriteLine(a + b);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
