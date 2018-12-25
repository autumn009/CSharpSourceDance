using System;
using System.Collections.Generic;

class X
{
    public List<EventHandler> handlers = new List<EventHandler>();
    public event EventHandler OnNotify
    {
        add
        {
            handlers.Add(value);
        }
        remove
        {
            handlers.Remove(value);
        }
    }
    public void KickHandler()
    {
        var e = new EventArgs();
        foreach (var item in handlers) item(this, e);
    }
}

class Program
{
    static void Main()
    {
        var a = new X();
        EventHandler handler = (sender, e) =>
         {
             Console.WriteLine("handler called!");
         };
        a.OnNotify += handler;
        a.KickHandler();
        a.OnNotify -= handler;
        a.KickHandler();
    }
}
