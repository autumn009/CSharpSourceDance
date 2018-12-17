using System;

class X
{
    public event EventHandler OnErrorNotify;
    public int Div (int x, int y)
    {
        if (y == 0)
        {
            OnErrorNotify(this, new EventArgs());
            return 0;
        }
        else return x / y;
    }
}

class Program
{
    static void Main()
    {
        var a = new X();
        a.OnErrorNotify += (sender, e) =>
        {
            Console.WriteLine("オブジェクトaでエラー発生! 0による除算の可能性があります。");
        };
        Console.WriteLine(a.Div(1, 0));
    }
}
