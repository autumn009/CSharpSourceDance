using System;

class X
{
    internal void Sub1() => Console.WriteLine("internal Sub");
    private void Sub2() => Console.WriteLine("private Sub");
}


class Program
{
    static void Main(string[] args)
    {
        try
        {
            dynamic x = new X();
            x.Sub1();
            x.Sub2();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
