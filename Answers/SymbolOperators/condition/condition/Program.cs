using System;

class Program
{
    static void Main()
    {
        int a = 1;
        int b = 2;
        if (a == b) Console.WriteLine("aとbは同じです。");
        if (a != b) Console.WriteLine("aとbは違います。");
        if (a > b) Console.WriteLine("aはbより大です。");
        if (a < b) Console.WriteLine("aはbより小です。");
        if (a >= b) Console.WriteLine("aはb以上です。");
        if (a <= b) Console.WriteLine("aはb以下です。");
    }
}
