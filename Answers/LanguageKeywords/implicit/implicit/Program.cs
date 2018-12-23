using System;

class A
{
    public int X;
}

class B
{
    public string X;
    public static implicit operator B(A a)
    {
        return new B() { X = a.X.ToString() };
    }
}

class Program
{
    static void Main()
    {
        A a = new A() { X = 4649 };
        B b = a;
        Console.WriteLine(b.X);
    }
}
