using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = { "Babe", "Adam", "Cyclon" };
        foreach (var item in from n in array orderby n select n) Console.WriteLine(item);
    }
}
