using System;

namespace opdracht1
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            string  naam;

            Console.Write("typ je naam hier in; ");
            naam = (Console.ReadLine());

            Console.WriteLine("je naam is " + naam.ToString());
            Console.ReadLine();
        }
    }
}
