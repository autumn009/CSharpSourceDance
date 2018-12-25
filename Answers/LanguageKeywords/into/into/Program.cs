using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Betty", "Anton", "Bob", "Cindy" };
        var q = from n in names group n by n.Substring(0, 1) into g where g.Count() >= 2 select g;
        foreach (var item in q)
            foreach (var m in item)
                Console.WriteLine(m);
    }
}
