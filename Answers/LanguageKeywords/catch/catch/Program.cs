using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 1;
            int b = 0;
            Console.WriteLine(a/b);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"変数bの値を確認して下さい。: {e}");
        }
    }
}
