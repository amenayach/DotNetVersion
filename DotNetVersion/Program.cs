using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetVersion
{
    class Program
    {
        static void Main(string[] args)
        {

            DotNet.GetVersionFromRegistry();

            Console.WriteLine("--------------------------------------------------");

            DotNet.Get45PlusFromRegistry();
            
            Console.ReadKey();

        }
    }
}
