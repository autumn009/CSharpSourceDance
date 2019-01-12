using System;

class Program
{
    static unsafe void Main()
    {
        int theValue = 4649 / 2;
        int* p = &theValue;
        int r = *p + *p + 1;
        Console.WriteLine(r);
    }
}
