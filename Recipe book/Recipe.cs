using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;


namespace Recipe_book
{
    class Recipes
    {
        public void RecipeClass() 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string r = @"     
                                            _____                     _         
                                           |  __ \                   | |        
                                           | |__) |___  ___ ___ _ __ | |_ _   _ 
                                           |  _  // _ \/ __/ _ \ '_ \| __| | | |
                                           | | \ \  __/ (_|  __/ |_) | |_| |_| |
                                           |_|  \_\___|\___\___| .__/ \__|\__, |
                                                               | |         __/ |
                                                               |_|        |___/ 

";
            Console.Write(r);
            Console.ForegroundColor = ConsoleColor.White;

            string a = @"   
           ***************************************************************************************************
                           Ak chcete zobraziť nejaký z týchto vynikajúcich receptov 
                stlačte na klávese číslo, ktoré je pri názve daného receptu a potvrďte klávesou Enter :).
           ***************************************************************************************************



                             .────────────────────────────────────────────────────────────────.
                             |                [S]  Späť do hlavnej ponuky                     |
                             *────────────────────────────────────────────────────────────────* ";


            Console.Write(a);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"    


                             
                             .────────────────────────────────────────────────────────────────.
                             |                   [0]  Talianske tiramisu                      |
                             *────────────────────────────────────────────────────────────────* 
          

                             .────────────────────────────────────────────────────────────────.
                             |         [1]  Cestoviny s kuracími prsiami Alfredo              |
                             *────────────────────────────────────────────────────────────────*                         
                              

                             .────────────────────────────────────────────────────────────────.
                             |            [2]  Karamelový cheesecake s čokoládou              |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |                        [3]  Polesníky                          |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |          [4]  Kurací perkelt so smotanou a haluškami           |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |              [5]  Banánové lievance s čokoládou                |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |              [6]  Gyros s kuracím mäsom v tortille             |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |                   [7]  Čokoládové cookies                      |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |               [8]  Čokoládová torta s jahodami                 |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |             [9]  Zemiakové pirohy s mäsovou plnkou             |
                             *────────────────────────────────────────────────────────────────*

";
            Console.Write(str);
            Console.ReadKey();


            char ch = Convert.ToChar(Console.Read());
            string chString = ch.ToString();
            switch (chString)
            {
                case "s":
                case "S":
                    {
                        Console.WriteLine("Späť do menu");
                        Console.ReadKey();
                        Menu hlavna = new Menu();
                        hlavna.DesignMenu();

                        break;
                    }

                case "0":
                    {
                 
                        Console.WriteLine("Talianske tiramisu.");

                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Cestoviny s kuracími prsiami Alfredo.");

                        break;
                    }


                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Karamelový cheesecake s čokoládou.");

                        break;
                    }


                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Polesníky.");

                        break;
                           
                    }


                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Kurací perkelt so smotanou a haluškami.");

                        break;
                    }


                case "5":
                    {
                        Console.Clear();
                        Console.WriteLine("Banánové lievance s čokoládou.");

                        break;
                    }

                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine("Gyros s kuracím mäsom v tortille.");

                        break;
                    }


                case "7":
                    {
                        Console.Clear();
                        Console.WriteLine("čokoládové cookies.");

                        break;
                    }

                case "8":
                    {
                        Console.Clear();
                        Console.WriteLine("Čokoládová torta s jahodami.");

                        break;
                    }

                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("Zemiakové pirohy s mäsovou plnkou.");

                        break;
                    }

                default:
                    {

                        Console.WriteLine("Vybral si si zlú možnosť");
                        Console.ReadKey();
                        Console.Clear();
                        Recipes rec = new Recipes();
                        rec.RecipeClass();

                        break;
                    }

            }

        }
    }
}
