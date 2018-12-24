using System;

    class Program
{
    static void Main()
    {
        object[] array = { "Hello!", 4639, new Program() };
        foreach (var item in array) Console.WriteLine(item.GetType().FullName);
    }
}
