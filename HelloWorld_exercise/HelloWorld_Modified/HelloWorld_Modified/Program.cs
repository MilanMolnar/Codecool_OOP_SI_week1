using System;

namespace HelloWorld_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            int argCount = args.Length;
            if (argCount != 0)
            {
                for (int i = 0; i < argCount; i++)
                {
                    Console.WriteLine($"Hello {args[i]}!");
                }
            }
            else
            {
                Console.WriteLine("Hello world!");
            }
        }
    }
}
