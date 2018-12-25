using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Bob" };
        foreach (var item in from n in names let m = n.ToUpper() where m.Count() >= 5 select m)
            Console.WriteLine(item);
    }
}
