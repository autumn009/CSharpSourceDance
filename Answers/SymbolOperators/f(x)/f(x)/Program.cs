using System;

class MyClass
{
    internal void MyMethod() => Console.WriteLine("MyMethod called!");
}

class Program
{
    static void Main()
    {
        var x = new MyClass();
        x.MyMethod();
    }
}
