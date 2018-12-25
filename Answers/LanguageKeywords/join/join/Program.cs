using System;
using System.Linq;

class IdName
{
    public int Id;
    public string Name;
}

class IdPrice
{
    public int Id;
    public int Price;
}

class Program
{
    static void Main()
    {
        IdName[] names = {
            new IdName(){Id=1,Name="TV"},
            new IdName(){Id=2,Name="Radio"},
        };
        IdPrice[] prices = {
            new IdPrice(){Id=2,Price=1000},
            new IdPrice(){Id=1,Price=10000},
        };

        var q = from n in names
                join m in prices on n.Id equals m.Id
                select new { ResultName = n.Name, ResultPrice = m.Price };

        foreach (var item in q) Console.WriteLine($"{item.ResultName}={item.ResultPrice}");
    }
}
