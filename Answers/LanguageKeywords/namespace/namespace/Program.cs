using System;
using A;

namespace A
{
    static class TheClass
    {
        internal static void Sub() => Console.WriteLine("In namespace A");
    }
}

namespace B
{
    static class TheClass
    {
        internal static void Sub() => Console.WriteLine("In namespace B");
    }
}

class Program
{
    static void Main()
    {
        TheClass.Sub();
        B.TheClass.Sub();
    }
}
