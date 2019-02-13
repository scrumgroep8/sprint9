using System;

namespace opdracht5
{
    class loginsystem
    {
        public static void Login()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
        }
    }

    class Mainsystem

    {   
        struct mp3
        {
            public int Id;
            public string Make;
            public string Model;
            public int MBSize;
            public double Price;
        };

        static void Main(string[] args)
        {
            loginsystem.Login();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

                    string keuze = "";

                    mp3 a;
                    a.Id = 1;
                    a.Make = "GET technologies.inc";
                    a.Model = "HF 410";
                    a.MBSize = 4096;
                    a.Price = 129.95;
                    
                    mp3 b;
                    b.Id = 1;
                    b.Make = "Far & Loud";
                    b.Model = "XM 600";
                    b.MBSize = 8192;
                    b.Price = 224.95;

                    mp3 c;
                    c.Id = 1;
                    c.Make = "Innotivative";
                    c.Model = "Z3";
                    c.MBSize = 512;
                    c.Price = 79.95;

                    mp3 d;
                    d.Id = 1;
                    d.Make = "Resistance S.A.";
                    d.Model = "3001";
                    d.MBSize = 4096;
                    d.Price = 124.95;

                    mp3 e;
                    e.Id = 1;
                    e.Make = "CBA";
                    e.Model = "NXT volume";
                    e.MBSize = 2048;
                    e.Price = 159.05;


                    while (keuze != "6")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1. mp3 - 1");
                        Console.WriteLine("2. mp3 - 2");
                        Console.WriteLine("3. mp3 - 3");
                        Console.WriteLine("4. mp3 - 4");
                        Console.WriteLine("5. mp3 - 5");
                        Console.WriteLine("6. exit");

                        keuze = Console.ReadLine();
                        Console.Clear();

                        if (keuze == "1")
                        {
                            Console.WriteLine("1. overzicht mp3 speler");
                            Console.WriteLine("");
                            Console.WriteLine(a.Id);
                            Console.WriteLine(a.Make);
                            Console.WriteLine(a.Model);
                            Console.WriteLine(a.MBSize);
                            Console.WriteLine(a.Price);
                        }
                        
                        else if (keuze == "2")
                        {
                            Console.WriteLine("1. overzicht mp3 speler");
                            Console.WriteLine("");
                            Console.WriteLine(b.Id);
                            Console.WriteLine(b.Make);
                            Console.WriteLine(b.Model);
                            Console.WriteLine(b.MBSize);
                            Console.WriteLine(b.Price);
                        }

                        else if (keuze == "3")
                        {
                            Console.WriteLine("1. overzicht mp3 speler");
                            Console.WriteLine("");
                            Console.WriteLine(c.Id);
                            Console.WriteLine(c.Make);
                            Console.WriteLine(c.Model);
                            Console.WriteLine(c.MBSize);
                            Console.WriteLine(c.Price);
                        }

                        else if (keuze == "4")
                        {
                            Console.WriteLine("1. overzicht mp3 speler");
                            Console.WriteLine("");
                            Console.WriteLine(d.Id);
                            Console.WriteLine(d.Make);
                            Console.WriteLine(d.Model);
                            Console.WriteLine(d.MBSize);
                            Console.WriteLine(d.Price);
                        }

                        else if (keuze == "5")
                        {
                            Console.WriteLine("1. overzicht mp3 speler");
                            Console.WriteLine("");
                            Console.WriteLine(e.Id);
                            Console.WriteLine(e.Make);
                            Console.WriteLine(e.Model);
                            Console.WriteLine(e.MBSize);
                            Console.WriteLine(e.Price);
                        }

                    }

                        Console.Clear();
                        Console.WriteLine("exit.");
                        Environment.Exit(0);
        }
    }
}
