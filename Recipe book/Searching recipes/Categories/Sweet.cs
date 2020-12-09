using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_book
{
    class Sweet
    {
        public void SweetCat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"
                             .────────────────────────────────────────────────────────────────.
                             |            [T]  Talianske tiramisu                             |
                             *────────────────────────────────────────────────────────────────* 

                             .────────────────────────────────────────────────────────────────.
                             |            [K]  Karamelový cheesecake s čokoládou              |
                             *────────────────────────────────────────────────────────────────* 

                             .────────────────────────────────────────────────────────────────.
                             |            [B]  Banánové lievance s čokoládou                  |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [C]  Čokoládové cookies                             |
                             *────────────────────────────────────────────────────────────────*";
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"
                             .────────────────────────────────────────────────────────────────.
                             |                         [S]  SPÄŤ                              |
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
                        Console.WriteLine("Späť do kategorií");
                        ByCategory byCategory = new ByCategory();
                        byCategory.SearchCat();

                        break;
                    }

                case "t":
                case "T":
                    {

                        Console.Clear();
                        Recipe0 recipe0 = new Recipe0();
                        recipe0.Recept0();

                        break;

                    }


                case "k":
                case "K":
                    {
                        Console.Clear();
                        Recipe2 recipe2 = new Recipe2();
                        recipe2.Recept2();

                        break;
                    }


                case "b":
                case "B":
                    {
                        Console.Clear();
                        Recipe5 recipe5 = new Recipe5();
                        recipe5.Recept5();
                      
                        break;
                    }


                case "c":
                case "C":
                    {
                        Console.Clear();
                        Recipe7 recipe7 = new Recipe7();
                        recipe7.Recept7();
                      
                        break;

                    }


                default:
                    {

                        Console.Clear();
                        Sweet sweet = new Sweet();
                        sweet.SweetCat();

                        break;
                    }


            }
        }
    }
}
