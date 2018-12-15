using System;

class Alpha
{
    public string Name { get; set; } = "アルファ";
}

class Beta : Alpha
{
    public new string Name { get; set; } = "ベータ";
    public void Sub()
    {
        Console.WriteLine(base.Name);
        Console.WriteLine(this.Name);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var x = new Beta();
        x.Sub();
    }
}

