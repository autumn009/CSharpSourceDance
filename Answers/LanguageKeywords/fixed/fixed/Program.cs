using System;

class Point
{
    public char[] a;
}
class Program
{
    unsafe static void Main()
    {
        // Variable pt is a managed variable, subject to garbage collection.
        Point pt = new Point();
        pt.a = "Hell!!".ToCharArray();
        fixed (char* p = &pt.a[3])
        {
            *(p + 1) = 'o';
        }
        Console.WriteLine(new string(pt.a));
    }
}
