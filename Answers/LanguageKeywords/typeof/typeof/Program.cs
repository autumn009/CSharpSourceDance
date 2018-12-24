using System;

interface ISample{}

class Program
{
    static void Main()
    {
        var name = typeof(ISample).FullName;
        Console.WriteLine(name);
    }
}
