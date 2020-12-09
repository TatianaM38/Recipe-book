using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace Recipe_book
{
    class ByDate
    {
        public void SearchDate()
        {
            string a = @"
                              RECEPTY SÚ ZORADENÉ OD NAJNOVŠIE PRIDANÉ PO TIE NAJSTARŠIE
                            --------------------------------------------------------------";
            Console.WriteLine(a);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string str = @"    


                             .────────────────────────────────────────────────────────────────.
                             |            [0]  Zemiakové pirohy s mäsovou plnkou              |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [1]  Cesnaková polievka                             |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [2]  Čokoládové cookies                             |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [3]  Gyros s kuracím mäsom v tortille               |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [4]  Banánové lievance s čokoládou                  |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [5]  Kurací perkelt so smotanou a haluškami         |
                             *────────────────────────────────────────────────────────────────*

                             .────────────────────────────────────────────────────────────────.
                             |            [6]  Polesníky                                      |
                             *────────────────────────────────────────────────────────────────* 

                              .────────────────────────────────────────────────────────────────.
                             |            [7]  Karamelový cheesecake s čokoládou              |
                             *────────────────────────────────────────────────────────────────* 

                             .────────────────────────────────────────────────────────────────.
                             |            [8]  Cestoviny s kuracími prsiami Alfredo           |
                             *────────────────────────────────────────────────────────────────*                         
                              
                             .────────────────────────────────────────────────────────────────.
                             |            [9]  Talianske tiramisu                             |
                             *────────────────────────────────────────────────────────────────*";
            Console.Write(str);

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
                        Console.WriteLine("Späť do menu");
                        Menu hlavna = new Menu();
                        hlavna.DesignMenu();

                        break;
                    }

                case "0":
                    {

                        Console.Clear();
                        Recipe9 recipe9 = new Recipe9();
                        recipe9.Recept9();


                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Recipe8 recipe8 = new Recipe8();
                        recipe8.Recept8();

                        break;
                    }


                case "2":
                    {
                        Console.Clear();
                        Recipe7 recipe7 = new Recipe7();
                        recipe7.Recept7();

                        break;
                    }


                case "3":
                    {
                        Console.Clear();
                        Recipe6 recipe6 = new Recipe6();
                        recipe6.Recept6();

                        break;

                    }


                case "4":
                    {
                        Console.Clear();
                        Recipe5 recipe5 = new Recipe5();
                        recipe5.Recept5();

                        break;
                    }


                case "5":
                    {
                        Console.Clear();
                        Recipe4 recipe4 = new Recipe4();
                        recipe4.Recept4();

                        break;
                    }

                case "6":
                    {
                        Console.Clear();
                        Recipe3 recipe3 = new Recipe3();
                        recipe3.Recept3();

                        break;
                    }


                case "7":
                    {
                        Console.Clear();
                        Recipe2 recipe2 = new Recipe2();
                        recipe2.Recept2(); ;

                        break;
                    }

                case "8":
                    {
                        Console.Clear();
                        Recipe1 recipe1 = new Recipe1();
                        recipe1.Recept1();

                        break;
                    }

                case "9":
                    {
                        Console.Clear();
                        Recipe0 recipe0 = new Recipe0();
                        recipe0.Recept0();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        Recipes rec = new Recipes();
                        rec.RecipeClass();

                        break;
                    }


            }

        }
    }
}
