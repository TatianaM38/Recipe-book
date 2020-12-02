using System;

namespace Recipe_book
{
    class AddRecipe
    {
        public void AddRec()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*Tu sa budú môcť pridávať nové recepty*");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                  .────────────────────────────────────────────────────────────────.
                  |                [S]  Späť do hlavnej ponuky                     |
                  *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);
            Console.ReadLine();

            char button1 = Convert.ToChar(Console.Read());
            string buttonString1 = button1.ToString();
            if (buttonString1 == "S")
            {
                Console.Clear();
                Menu hlavna = new Menu();
                hlavna.DesignMenu();
            }
            else if (buttonString1 == "s")
            {
                Console.Clear();
                Menu hlavna = new Menu();
                hlavna.DesignMenu();
            }


        }
    }
}
