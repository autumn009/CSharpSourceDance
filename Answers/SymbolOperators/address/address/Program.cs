using System;

struct MyStruct
{
    public void Sub() => Console.WriteLine("Hello in MyStruct");
}

class Program
{
    static unsafe void Main()
    {
        MyStruct theValue;
        MyStruct* p = &theValue;
        p->Sub();
    }
}
