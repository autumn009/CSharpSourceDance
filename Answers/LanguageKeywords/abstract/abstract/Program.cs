using System;

abstract class ClassA
{
    public abstract void Sub();
}

class ClassB : ClassA
{
    public override void Sub()
    {
        Console.WriteLine("I'm ClassB.Sub!");
    }
}

class Program
{
    static void Main()
    {
        ClassA a = new ClassB();
        a.Sub();
    }
}
