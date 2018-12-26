using System;

class Program
{
    static int Prop
    {
        set
        {
            Console.WriteLine($"プロパティPropに{value}を設定しようとしています。");
        }
    }

    static void Main()
    {
        Prop = 4649;
    }
}
