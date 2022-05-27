using NugetLibrary;
using PaketLibrary;
using System;

namespace PartialMigrationToPaket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NugetClass.Invoke());
            Console.WriteLine(PaketClass.Invoke());
        }
    }
}
