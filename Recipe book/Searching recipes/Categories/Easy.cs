using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_book
{
    class Easy
    {
        public void EasyCat()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string str = @"

                             .────────────────────────────────────────────────────────────────.
                             |              [0]  Talianske tiramisu                           |
                             *────────────────────────────────────────────────────────────────* 
          

                             .────────────────────────────────────────────────────────────────.
                             |              [1]  Polesníky                                    |
                             *────────────────────────────────────────────────────────────────*               


                             .────────────────────────────────────────────────────────────────.
                             |              [2]  Banánové lievance s čokoládou                |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |              [3]  Gyros s kuracím mäsom v tortille             |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |              [4]  Čokoládové cookies                           |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |              [5]  Cesnaková polievka                           |
                             *────────────────────────────────────────────────────────────────*";
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                             .────────────────────────────────────────────────────────────────.
                             |                         [S]  SPÄŤ                              |
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
                        Console.WriteLine("Späť do kategorií");
                        ByCategory byCategory = new ByCategory();
                        byCategory.SearchCat();

                        break;
                    }

                case "0":
                    {

                        Console.Clear();
                        Recipe0 recipe0 = new Recipe0();
                        recipe0.Recept0();


                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Recipe3 recipe3 = new Recipe3();
                        recipe3.Recept3();

                        break;
                    }


                case "2":
                    {
                        Console.Clear();
                        Recipe5 recipe5 = new Recipe5();
                        recipe5.Recept5();

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
                        Recipe7 recipe7 = new Recipe7();
                        recipe7.Recept7();

                        break;
                    }


                case "5":
                    {
                        Console.Clear();
                        Recipe8 recipe8 = new Recipe8();
                        recipe8.Recept8();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        Easy easy = new Easy();
                        easy.EasyCat();
                        break;
                    }


            }
        }
    }
}
