using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Betty", "Anton", "Bob" };
        var q = from n in names group n by n.Substring(0, 1);
        foreach (var item in q)
            foreach (var m in item)
                Console.WriteLine(m);
    }
}
