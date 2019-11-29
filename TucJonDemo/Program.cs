using System;

namespace TucJonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej!");
            Console.WriteLine("Vad heter du?");
            Console.Write("Svara: ");

            string name = Console.ReadLine();
            Console.WriteLine($"Du heter {name}");
        }
    }
}
