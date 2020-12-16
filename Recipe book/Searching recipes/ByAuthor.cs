using System;


namespace Recipe_book
{
    class ByAuthor
    {
        public void SearchAut()
        {
            string name = @"
                            ZORADENÉ MENÁ AUTOROV  A-Z        
                           ------------------------------";
            Console.WriteLine(name);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string str = @"
                             .────────────────────────────────────────────────────────────────.
                             |                   [0]  Karin - Live to bake                    |
                             *────────────────────────────────────────────────────────────────* 
          

                             .────────────────────────────────────────────────────────────────.
                             |                   [1]  Marcel Ihnačák                          |
                             *────────────────────────────────────────────────────────────────*                         
                              

                             .────────────────────────────────────────────────────────────────.
                             |                   [2]  Nigella Lawson                          |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |                   [3]  Petra Eliašová                          |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |                   [4]  Recept starej mamy                      |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |                   [5]  Viktoria                                |
                             *────────────────────────────────────────────────────────────────*";
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"
                             .────────────────────────────────────────────────────────────────.
                             |                         [S]  SPÄŤ                              |
                             *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);

            char button = Convert.ToChar(Console.Read());
            string buttonString = button.ToString();
            switch (buttonString)
            {
                case "s":
                case "S":
                    {
                        Console.Clear();
                        Console.WriteLine("Späť do vyhľadávania");
                        Find find = new Find();
                        find.FindRecipe();

                        break;
                    }

                case "0":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        string s2 = @"
                             .────────────────────────────────────────────────────────────────.
                             |            [0]  Karamelový cheesecake s čokoládou              |
                             *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s2);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string s1 = @"

                            .────────────────────────────────────────────────────────────────.
                            |                           [S]  SPÄŤ                            |
                            *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s1);
                        Console.ReadLine();

                        char button1 = Convert.ToChar(Console.Read());
                        string buttonString1 = button1.ToString();
                        if (buttonString1 == "0")
                        {
                            Console.Clear();
                            Recipe2 recipe2 = new Recipe2();
                            recipe2.Recept2();
                        }
                        else if (buttonString1 == "s")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();

                        }
                        else if (buttonString1 =="S" )
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();
                        }

                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        string s2 = @"
                             .────────────────────────────────────────────────────────────────.
                             |            [0]  Kurací perkelt so smotanou a haluškami         |
                             *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s2);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string s1 = @"

                            .────────────────────────────────────────────────────────────────.
                            |                           [S]  SPÄŤ                            |
                            *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s1);
                        Console.ReadLine();

                        char button1 = Convert.ToChar(Console.Read());
                        string buttonString1 = button1.ToString();
                        if (buttonString1 == "0")
                        {
                            Console.Clear();
                            Recipe4 recipe4 = new Recipe4();
                            recipe4.Recept4();
                        }
                        else if (buttonString1 == "s")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();

                        }
                        else if (buttonString1 == "S")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();
                        }

                        break;
                    }


                case "2":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        string s2 = @"
                             .────────────────────────────────────────────────────────────────.
                             |                [0]   Čokoládové cookies                        |
                             *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s2);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string s1 = @"

                            .────────────────────────────────────────────────────────────────.
                            |                           [S]  SPÄŤ                            |
                            *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s1);

                        Console.ReadLine();

                        char button1 = Convert.ToChar(Console.Read());
                        string buttonString1 = button1.ToString();
                        if (buttonString1 == "0")
                        {
                            Console.Clear();
                            Recipe7 recipe7 = new Recipe7();
                            recipe7.Recept7();
                        }
                        else if (buttonString1 == "s")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();

                        }
                        else if (buttonString1 == "S")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();
                        }

                        break;
                    }


                case "3":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        string s2 = @"
                             .────────────────────────────────────────────────────────────────.
                             |                  [0]  Talianske tiramisu                       |
                             *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s2);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string s1 = @"

                            .────────────────────────────────────────────────────────────────.
                            |                           [S]  SPÄŤ                            |
                            *────────────────────────────────────────────────────────────────* ";
                        Console.WriteLine(s1);
                        Console.ReadLine();

                        char button1 = Convert.ToChar(Console.Read());
                        string buttonString1 = button1.ToString();
                        if (buttonString1 == "0")
                        {
                            Console.Clear();
                            Recipe0 recipe0 = new Recipe0();
                            recipe0.Recept0();
                        }
                        else if (buttonString1 == "s")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();

                        }
                        else if (buttonString1 == "S")
                        {
                            Console.Clear();
                            ByAuthor by = new ByAuthor();
                            by.SearchAut();
                        }

                        break;

                    }


                case "4":
                    {
                        Console.Clear();
                        Author4 author4 = new Author4();
                        author4.ReceptyBabky();

                        break;
                    }


                case "5":
                    {
                        Author5 author5 = new Author5();
                        author5.Viktoria();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        ByAuthor byAuthor = new ByAuthor();
                        byAuthor.SearchAut();

                        break;
                    }


            }

        }

    }
}
