using System;

struct MyStruct
{
    public int v;
}

class Program
{
    static unsafe void Main()
    {
        MyStruct theValue;
        MyStruct* p = &theValue;
        p->v = 4649;
        Console.WriteLine(theValue.v);
    }
}
