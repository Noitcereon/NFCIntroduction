using System;

namespace NFCConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.WriteLine("Worker starting");
            worker.Start();

            Console.WriteLine("Worker finished\n" +
                              "Press any key to exit...");
            Console.ReadKey();
        }
    }
}
