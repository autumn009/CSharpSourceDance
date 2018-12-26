using System;

class A
{
    internal void Sub() => Console.WriteLine("I'm A.Sub");
}


class B<T> where T : A
{
    internal void Sub(T t) => t.Sub();
}


class Program
{
    static void Main()
    {
        var x = new B<A>();
        x.Sub(new A());
    }
}
