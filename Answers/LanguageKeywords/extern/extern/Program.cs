using System;
using System.Runtime.InteropServices;
class ExternTest
{
    [DllImport("User32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr h, string m, string c, int type);

    static int Main()
    {
        return MessageBox((IntPtr)0, "Hello from Extern Sample", "Extern Sample", 0);
    }
}
