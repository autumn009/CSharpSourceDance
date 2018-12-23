using System;

interface IContravariant<in A>
{
    void X(A x);
}

class Sample<A> : IContravariant<A>
{
    public void X(A x)
    {
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main()
    {
        IContravariant<Object> iobj = new Sample<Object>();
        IContravariant<String> istr;

        istr = iobj;
        istr.X("Hello Contravariant!");
    }
}
