using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task t = Task.Delay(1000);
        Console.WriteLine("Wait 1 sec");
        await t;
        Console.WriteLine("Finish!");
    }
}
