using System;

class A
{
    public int X;
}

class B
{
    public string X;
    public static explicit operator B(A a)
    {
        return new B() { X = a.X.ToString() };
    }
}

class Program
{
    static void Main()
    {
        A a = new A() { X = 4649 };
        B b = (B)a;
        Console.WriteLine(b.X);
    }
}
