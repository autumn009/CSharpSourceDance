using System;

namespace MyNS
{
    class MyClass
    {
        internal static void MyMethod1()
        {
            Console.WriteLine("MyMethod1 Called");
        }
        internal void MyMethod2()
        {
            Console.WriteLine("MyMethod2 Called");
        }
    }
}

class Program
{
    static void Main()
    {
        MyNS.MyClass.MyMethod1();
        var x = new MyNS.MyClass();
        x.MyMethod2();
    }
}

