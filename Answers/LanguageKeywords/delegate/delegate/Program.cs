using System;

delegate void MyDelegate();

class Program
{
    static void Main()
    {
        MyDelegate doit = delegate ()
        {
            Console.WriteLine("Hello World!");
        };
        doit();
    }
}
