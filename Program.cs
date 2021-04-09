using System;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("---------------------");
            Console.WriteLine("Hola mundo!");
            System.Console.WriteLine("Como te llamas?");
            var nombre = Console.ReadLine();
            Console.WriteLine(@"Hi {0}", nombre);
            System.Console.WriteLine("---------------------");
        }
    }
}
