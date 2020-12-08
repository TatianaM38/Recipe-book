using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
namespace Recipe_book
{
    class ByCategory
    {
        public void SearchCat()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string str = @"
                                                                     _
                                         _  __     _                //      _
                                        | |/ /__ _| |_ ___  __ _  ___  _ __(_) ___ 
                                        | ' // _` | __/ _ \/ _` |/ _ \| '__| |/ _ \
                                        | . \ (_| | ||  __/ (_| | (_) | |  | |  __/
                                        |_|\_\__,_|\__\___|\__, |\___/|_|  |_|\___|
                                                            |___/                   ";
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string cat = @"
                             .────────────────────────────────────────────────────────────────.
                             |                    [0]  SLADKÉ RECEPTY                         |
                             *────────────────────────────────────────────────────────────────* 
          

                             .────────────────────────────────────────────────────────────────.
                             |                    [1]  SLANÉ RECEPTY                          |
                             *────────────────────────────────────────────────────────────────*                         
                              

                             .────────────────────────────────────────────────────────────────.
                             |                    [2]  NÍZKA NÁROČNOSŤ                        |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |                    [3]  STREDNÁ NÁROČNOSŤ                      |
                             *────────────────────────────────────────────────────────────────*";
            Console.WriteLine(cat);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                             .────────────────────────────────────────────────────────────────.
                             |                [S]  SPÄŤ NA VŠETKY KATEGÓRIE                   |
                             *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);
            Console.ReadLine();

            char button = Convert.ToChar(Console.Read());
            string buttonString = button.ToString();
            switch (buttonString)
            {
                case "s":
                case "S":
                    {
                        Console.Clear();
                        Console.WriteLine("Späť na vyhľadávanie");
                        Find findr = new Find();
                        findr.FindRecipe();

                        break;
                    }

                case "0":
                    {

                        Console.Clear();
                        Sweet sweet = new Sweet();
                        sweet.SweetCat();

                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Salty salty = new Salty();
                        salty.SaltyCat();

                        break;
                    }


                case "2":
                    {
                        Easy easy = new Easy();
                        easy.EasyCat();

                        break;
                    }


                case "3":
                    {
                        Console.Clear();
                        Medium medium = new Medium();
                        medium.MediumCat();
                       

                        break;

                    }



                default:
                    {
                        Console.Clear();
                        ByCategory byCategory = new ByCategory();
                        byCategory.SearchCat();

                        break;
                    }


            }
        }
    }
}
