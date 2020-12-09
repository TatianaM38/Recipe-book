using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_book
{
    class Salty
    {
        public void SaltyCat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"


                             .────────────────────────────────────────────────────────────────.
                             |           [0]  Cestoviny s kuracími prsiami Alfredo            |
                             *────────────────────────────────────────────────────────────────*       


                             .────────────────────────────────────────────────────────────────.
                             |           [1]  Polesníky                                       |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |           [2]  Kurací perkelt so smotanou a haluškami          |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |           [3]  Gyros s kuracím mäsom v tortille                |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |           [4]  Cesnaková polievka                              |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |          [5]  Zemiakové pirohy s mäsovou plnkou                |
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
                        Recipe1 recipe1 = new Recipe1();
                        recipe1.Recept1();

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
                        Recipe4 recipe4 = new Recipe4();
                        recipe4.Recept4();

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
                        Recipe8 recipe8 = new Recipe8();
                        recipe8.Recept8();

                        break;
                    }


                case "5":
                    {
                        Console.Clear();
                        Recipe9 recipe9 = new Recipe9();
                        recipe9.Recept9();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        Salty salty = new Salty();
                        salty.SaltyCat();

                        break;
                    }


            }




        }
    }
}
