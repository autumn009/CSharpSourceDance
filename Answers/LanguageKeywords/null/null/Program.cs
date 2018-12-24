using System;
using System.IO;

class Program
{
    static void Main()
    {
        var reader = new StringReader("A\r\nB\r\nC");
        for (; ; )
        {
            var s = reader.ReadLine();
            if (s == null) break;
            Console.Write(s);
        }
    }
}
