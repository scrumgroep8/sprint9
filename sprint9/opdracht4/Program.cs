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

            //poging counter start bij 1
            int pogingen = 1;
            
            //boolean die aangeeft of je wel of niet ingelogd bent
            bool ingelogd = false;

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

                    // resultaten

                    if (pogingen > 3)
                    {
                        Console.WriteLine("jammer te vaak fout");
                    }
                    else
                    {
                        Console.WriteLine("je bent ingelogd");

                        Console.WriteLine("je naam is " + naam.ToString());

                        ingelogd = true;
                    }
        }
    }
}
