using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            //poging counter
            int pogingen = 0;

            string  naam;

            Console.Write("typ je naam hier in; ");
            naam = (Console.ReadLine());

            //for loop die er voor zorgt dat je maar 3 keer kan
            for (int i = 0; i < 3; i++)
            {

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            if (password != "password")
                pogingen++;
            else
                break;
            }

            //resultaten
            if (pogingen > 2)
            {
                Console.WriteLine("3 keer fout wachtwoord");
            }
            else
            {
                Console.WriteLine("je bent ingelogd");

                Console.WriteLine("je naam is " + naam.ToString());
            }
            Console.ReadKey();
        }
    }
}
