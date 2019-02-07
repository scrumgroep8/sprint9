using System;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            //////////////////////////////////////////////-BEGINNING LOGIN SYSTEM-//////////////////////////////////////////////

            //poging counter start bij 1
            int pogingen = 1;

            //string voor je naam
            string  naam;
            //

            //

            //

            // voorstukje waar je je naam invoert

            Console.Write("typ je naam hier in; ");
            naam = (Console.ReadLine());

                //
                
                //

                //

                // for loop die er voor zorgt dat je maar 3 keer kan

                for (int i = 0; i < 3; i++)
                {
                
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                Console.WriteLine("je hebt " + pogingen.ToString() + " keer geprobeerd");

                if (pogingen == 2)
                    {
                        Console.WriteLine("LET OP JE DIT IS JE LAATSTE KANS");
                    }

                if (password != "SHARPSOUND")
                    {
                    pogingen++;
                    }
                else
                    {
                    break;
                    }
                }

                    //
                    
                    //

                    //

                    // als hij te vaak fout is dan doet hij een exit. als hij goed is dan gaat de applicatie verder.

                    if (pogingen > 3)
                    {
                        Console.Clear();

                        Console.WriteLine("3x fout! shutdown.");

                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("je bent ingelogd");

                        Console.WriteLine("je naam is " + naam.ToString());
                    }

                    //////////////////////////////////////////////-END LOGIN SYSTEM-//////////////////////////////////////////////

                    string keuze = "";

                    

                    while (keuze != "3")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1. menu");
                        Console.WriteLine("2. iets");
                        Console.WriteLine("3. exit");

                        keuze = Console.ReadLine();

                        if (keuze == "1")
                        {   
                             Console.Clear();
                            Console.WriteLine("1. overzicht mp3 speler");
                        }
                        else if (keuze == "2")
                        {   
                            Console.Clear();
                            Console.WriteLine("2. overzicht iets");
                        }

                    }

                        Console.Clear();
                        Console.WriteLine("exit.");
                        Environment.Exit(0);
                
        }
    }
}
