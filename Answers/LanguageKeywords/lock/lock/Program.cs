using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        object sync = new object();
        Action act = () =>
        {
            for (; ; )
            {
                lock (sync)
                {
                    Console.Write("O");
                    Console.Write("K");
                }
            }
        };
        Parallel.Invoke(act, act);
    }
}
