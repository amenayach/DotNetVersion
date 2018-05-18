using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine();

            DotNet.GetVersionFromRegistry();

            PrintLine();

            DotNet.Get45PlusFromRegistry();

            PrintLine();

            Console.ForegroundColor = ConsoleColor.White;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }

        private static void PrintLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
