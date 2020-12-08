using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe_book
{
    class Medium
    {
        public void MediumCat()
        {
            string str = @"
                             .────────────────────────────────────────────────────────────────.
                             |         [0]  Cestoviny s kuracími prsiami Alfredo              |
                             *────────────────────────────────────────────────────────────────*                         
                              

                             .────────────────────────────────────────────────────────────────.
                             |            [1]  Karamelový cheesecake s čokoládou              |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |          [2]  Kurací perkelt so smotanou a haluškami           |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |             [3]  Zemiakové pirohy s mäsovou plnkou             |
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
                        Recipe2 recipe2 = new Recipe2();
                        recipe2.Recept2();

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
                        Recipe9 recipe9 = new Recipe9();
                        recipe9.Recept9();



                        break;

                    }


                default:
                    {

                        Console.Clear();
                        Medium medium = new Medium();
                        medium.MediumCat();
                        break;
                    }


            }
        }
    }
}
