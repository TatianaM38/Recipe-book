using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_book
{
    class Find 
    {
        public void FindRecipe() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"    


                             
                            .────────────────────────────────────────────────────────────────.
                            |                 [N]  NÁJSŤ RECEPT PODĽA NÁZVU                  |
                            *────────────────────────────────────────────────────────────────* 
          

                            .────────────────────────────────────────────────────────────────.
                            |                 [K]  NÁJSŤ RECEPT PODĽA KATEGÓRIE              |
                            *────────────────────────────────────────────────────────────────*                         
                              

                            .────────────────────────────────────────────────────────────────.
                            |                 [A]  NÁJSŤ RECEPT PODĽA AUTORA                 |
                            *────────────────────────────────────────────────────────────────* 


                            .────────────────────────────────────────────────────────────────.
                            |                 [D]  NÁJSŤ RECEPT PODĽA DÁTUMU PRIDANIA        |
                            *────────────────────────────────────────────────────────────────* 


                            .────────────────────────────────────────────────────────────────.
                            |                 [H]  NÁJSŤ RECEPT PODĽA HODNOTENIA             |
                            *────────────────────────────────────────────────────────────────*";

            Console.WriteLine(str);
         
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                            .────────────────────────────────────────────────────────────────.
                            |                       [S]  SPÄŤ DO MENU                        |
                            *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);
            Console.ReadLine();

            char button1 = Convert.ToChar(Console.Read());
            string buttonString1 = button1.ToString();
             switch (buttonString1)
            {
                case "s":
                case "S":
                    {
                        Console.Clear();
                        Console.WriteLine("Späť do menu");
                        Menu hlavna = new Menu();
                        hlavna.DesignMenu();

                        break;
                    }

                case "n":
                case "N":
                    {

                        Console.Clear();
                        ByName byName = new ByName();
                        byName.SearchName();


                        break;

                    }


                case "k":
                case "K":
                    {
                        Console.Clear();
                        ByCategory byCategory = new ByCategory();
                        byCategory.SearchCat();

                        break;
                    }


                case "a":
                case "A":
                    {
                        Console.Clear();
                        ByAuthor byAuthor = new ByAuthor();
                        byAuthor.SearchAut();
                        break;
                    }


                case "d":
                case "D":
                    {
                        Console.Clear();
                        ByDate byDate = new ByDate();
                        byDate.SearchDate();
                        

                        break;

                    }


                case "h":
                case "H":
                    {
                        Console.Clear();
                        ByRating byRating = new ByRating();
                        byRating.SearchRat();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        
                        break;
                    }


            }

            
        }
 
    }
}
