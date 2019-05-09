using System;
using System.Threading.Tasks;

namespace Daemon.Core
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Delay(2000);
            Console.WriteLine("Hello World!");
        }
    }
}
