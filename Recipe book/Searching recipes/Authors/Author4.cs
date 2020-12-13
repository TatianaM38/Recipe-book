using System;


namespace Recipe_book
{
    class Author4
    {
        public void ReceptyBabky()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"
                             .────────────────────────────────────────────────────────────────.
                             |               [0]  Polesníky                                   |
                             *────────────────────────────────────────────────────────────────* 


                             .────────────────────────────────────────────────────────────────.
                             |               [1]  Cesnaková polievka                          |
                             *────────────────────────────────────────────────────────────────*


                             .────────────────────────────────────────────────────────────────.
                             |               [2]  Zemiakové pirohy s mäsovou plnkou           |
                             *────────────────────────────────────────────────────────────────*";
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                             .────────────────────────────────────────────────────────────────.
                             |                           [S]  SPÄŤ                            |
                             *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);


            char button1 = Convert.ToChar(Console.Read());
            string buttonString1 = button1.ToString();
            switch (buttonString1)
            {
                case "s":
                case "S":
                    {
                        Console.Clear();
                        Console.WriteLine("Späť");
                        ByAuthor byAuthor = new ByAuthor();
                        byAuthor.SearchAut();
                        

                        break;
                    }

                case "0":
                    {

                        Console.Clear();
                        Recipe3 recipe3 = new Recipe3();
                        recipe3.Recept3();

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
                        Recipe9 recipe9 = new Recipe9();
                        recipe9.Recept9();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        Author4 author = new Author4();
                        author.ReceptyBabky();

                        break;
                    }


            }

        }
    }
}
