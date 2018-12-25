using System;
using System.Threading.Tasks;

class Program
{
    static volatile int x;

    static async Task Main()
    {
       _ = Task.Run(()=> {
            for (int i = 0; ; i++)
            {
                x++;
            }
        });
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(x);
            await Task.Delay(500);
        }
    }
}
