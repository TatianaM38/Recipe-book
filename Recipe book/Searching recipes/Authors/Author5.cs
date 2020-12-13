using System;


namespace Recipe_book
{
    class Author5
    {
        public void Viktoria()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string str = @"
                             .────────────────────────────────────────────────────────────────.
                             |           [0]  Cestoviny s kuracími prsiami Alfredo            |
                             *────────────────────────────────────────────────────────────────* 

                             .────────────────────────────────────────────────────────────────.
                             |           [1]  Gyros s kuracím mäsom v tortille                |
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
                        Recipe1 recipe1 = new Recipe1();
                        recipe1.Recept1();

                        break;

                    }


                case "1":
                    {
                        Console.Clear();
                        Recipe6 recipe6 = new Recipe6();
                        recipe6.Recept6();

                        break;
                    }

                default:
                    {

                        Console.Clear();
                        Author5 author = new Author5();
                        author.Viktoria();

                        break;
                    }


            }
        }
    }
}
