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
            public int Stock;
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
                    a.Stock = 1243;
                    
                    mp3 b;
                    b.Id = 2;
                    b.Make = "Far & Loud";
                    b.Model = "XM 600";
                    b.MBSize = 8192;
                    b.Price = 224.95;
                    b.Stock = 5342;

                    mp3 c;
                    c.Id = 3;
                    c.Make = "Innotivative";
                    c.Model = "Z3";
                    c.MBSize = 512;
                    c.Price = 79.95;
                    c.Stock = 553;

                    mp3 d;
                    d.Id = 4;
                    d.Make = "Resistance S.A.";
                    d.Model = "3001";
                    d.MBSize = 4096;
                    d.Price = 124.95;
                    d.Stock = 241;

                    mp3 e;
                    e.Id = 5;
                    e.Make = "CBA";
                    e.Model = "NXT volume";
                    e.MBSize = 2048;
                    e.Price = 159.05;
                    e.Stock = 91;


                    while (keuze != "3")
                    {
                        string keuzemp3 = "";

                        string keuzestock = "";

                        Console.WriteLine("");
                        Console.WriteLine("1. mp3");
                        Console.WriteLine("2. iets");
                        Console.WriteLine("3. exit");

                        keuze = Console.ReadLine();
                        Console.Clear();

                        if (keuze == "1")
                        {
                            while (keuzemp3 != "6")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("1. GET technologies.inc");
                                Console.WriteLine("2. Far & Loud");
                                Console.WriteLine("3. Innotivative");
                                Console.WriteLine("4. Resistance S.A.");
                                Console.WriteLine("5. CBA");
                                Console.WriteLine("6. exit");

                                keuzemp3 = Console.ReadLine();
                                Console.Clear();

                                if (keuzemp3 == "1")
                                {
                                    Console.WriteLine("1. overzicht mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + a.Id);
                                    Console.WriteLine("make: " + a.Make);
                                    Console.WriteLine("model: " + a.Model);
                                    Console.WriteLine("mbsize: " + a.MBSize);
                                    Console.WriteLine("price: " + a.Price);
                                    
                                }
                                
                                else if (keuzemp3 == "2")
                                {
                                    Console.WriteLine("2. overzicht mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + b.Id);
                                    Console.WriteLine("make: " + b.Make);
                                    Console.WriteLine("model: " + b.Model);
                                    Console.WriteLine("mbsize: " + b.MBSize);
                                    Console.WriteLine("price: " + b.Price);
                                    
                                }

                                else if (keuzemp3 == "3")
                                {
                                    Console.WriteLine("3. overzicht mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + c.Id);
                                    Console.WriteLine("make: " + c.Make);
                                    Console.WriteLine("model: " + c.Model);
                                    Console.WriteLine("mbsize: " + c.MBSize);
                                    Console.WriteLine("price: " + c.Price);
                                   
                                }

                                else if (keuzemp3 == "4")
                                {
                                    Console.WriteLine("4. overzicht mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + d.Id);
                                    Console.WriteLine("make: " + d.Make);
                                    Console.WriteLine("model: " + d.Model);
                                    Console.WriteLine("mbsize: " + d.MBSize);
                                    Console.WriteLine("price: " + d.Price);
                                    
                                }

                                else if (keuzemp3 == "5")
                                {
                                    Console.WriteLine("5. overzicht mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + e.Id);
                                    Console.WriteLine("make: " + e.Make);
                                    Console.WriteLine("model: " + e.Model);
                                    Console.WriteLine("mbsize: " + e.MBSize);
                                    Console.WriteLine("price: " + e.Price);
                                
                                }

                            }

                        }

                        if (keuze == "2")
                        {
                            while (keuzestock != "6")
                            {

                                Console.WriteLine("");
                                Console.WriteLine("1. GET technologies.inc");
                                Console.WriteLine("2. Far & Loud");
                                Console.WriteLine("3. Innotivative");
                                Console.WriteLine("4. Resistance S.A.");
                                Console.WriteLine("5. CBA");
                                Console.WriteLine("6. exit");

                                keuzestock = Console.ReadLine();
                                Console.Clear();
                                
                                if (keuzestock == "1")
                                {
                                    Console.WriteLine("1. voorraad mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + a.Id);
                                    Console.WriteLine("stock: " + a.Stock);
                                    
                                }
                                
                                else if (keuzestock == "2")
                                {
                                    Console.WriteLine("2. voorraad mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + b.Id);
                                    Console.WriteLine("stock: " + b.Stock);
                                    
                                }

                                else if (keuzestock == "3")
                                {
                                    Console.WriteLine("3. voorraad mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + c.Id);
                                    Console.WriteLine("stock: " + c.Stock);
                                   
                                }

                                else if (keuzestock == "4")
                                {
                                    Console.WriteLine("4. voorraad mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + d.Id);
                                    Console.WriteLine("stock: " + d.Stock);
                                    
                                }

                                else if (keuzestock == "5")
                                {
                                    Console.WriteLine("5. voorraad mp3 speler");
                                    Console.WriteLine("");
                                    Console.WriteLine("id: " + e.Id);
                                    Console.WriteLine("stock: "+ e.Stock);
                                
                                }
                            }
                        }
                    }

                        Console.Clear();
                        Console.WriteLine("exit.");
                        Environment.Exit(0);
        }
    }
}