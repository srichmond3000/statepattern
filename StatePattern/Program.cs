using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessor processor = new Processor();
            processor.Process();

            Console.ReadLine();
        }
    }
}
