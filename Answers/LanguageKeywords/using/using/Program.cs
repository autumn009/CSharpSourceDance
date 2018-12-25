using System;

class X : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("X.Dispose!"); ;
    }
}

class Program
{
    static void Main()
    {
        using (var x = new X())
        {
            return;
        }
        Console.WriteLine("Never Run");
    }
}
