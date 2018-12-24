using System;


class Program
{
    unsafe static void UnsafeProcess()
    {
        int i = 123;
        int* p = &i;
        Console.WriteLine(*p);
    }

    static void Main()
    {
        UnsafeProcess();
    }
}
