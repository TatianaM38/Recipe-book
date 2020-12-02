using System;

namespace Recipe_book
{
    class Menu 
    {
        public void DesignMenu()
        {
         
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "Yummy book";
            string title = @"
                           * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *                        
                           *                                                                   *
                           *  _   _ _   _ _ __ ___  _ __ ___  _   _  | |__   ___   ___ | | __  *
                           * | | | | | | | '_ ` _ \| '_ ` _ \| | | | | '_ \ / _ \ / _ \| |/ /  * 
                           * | |_| | |_| | | | | | | | | | | | |_| | | |_) | (_) | (_) |   <   *
                           *  \__, |\__,_|_| |_| |_|_| |_| |_|\__, | |_.__/ \___/ \___/|_|\_\  *
                           *   __/ |                           __/ |                           *
                           *  |___/                           |___/                            *            
                           *                                                                   *
                           * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ";

            Console.WriteLine(title);
   
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string recepty = @" 
                            .────────────────────────────────────────────────────────────────.
                            |                        [R]  RECEPTY                            |
                            *────────────────────────────────────────────────────────────────* 

                            .────────────────────────────────────────────────────────────────.
                            |                        [N]  NÁJSŤ RECEPT                       |
                            *────────────────────────────────────────────────────────────────* 

                            .────────────────────────────────────────────────────────────────.
                            |                        [P]  PRIDAŤ RECEPT                      |
                            *────────────────────────────────────────────────────────────────* 

                            .────────────────────────────────────────────────────────────────.
                            |                        [A]  O APLIKÁCIÍ                        |
                            *────────────────────────────────────────────────────────────────* ";
                                     
                                    

              Console.Write(recepty);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string ext = @"

                            .────────────────────────────────────────────────────────────────.
                            |                        [U] UKONČIŤ APLIKÁCIU                   |
                            *────────────────────────────────────────────────────────────────*

";
            Console.WriteLine(ext);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                   --------------------------------------------------------------------------------");
            Console.WriteLine("                     Ak chcete prejsť na recepty, stlačte na klávesu 'r' a potvrďte klávesou Enter.");
            Console.WriteLine("                  *  Ak chcete nájsť recepty, stlačte na klávesu 'n' a potvrďte klávesou Enter.    *");
            Console.WriteLine("                     Ak chcete pridať recepty, stlačte na klávesu 'p' a potvrďte klávesou Enter.");
            Console.WriteLine("                   --------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkRed;
           
          

            char button = Convert.ToChar(Console.Read());
            string buttonString = button.ToString();
            switch (buttonString)
            {

                case "r":
                case "R":
                     {
                        Console.Clear();
                        Recipes rec = new Recipes();
                        rec.RecipeClass();
                       

                        break;
                     }

                case "n":
                case "N":
                    {
                        Console.Clear();
                        Find findr = new Find();
                        findr.FindRecipe();

                        break;
                    }

                case "p":
                case "P":
                    {
                        Console.Clear();
                        AddRecipe addr = new AddRecipe();
                        addr.AddRec();

                        break;           
                    }

                case "a":
                case "A":
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        string str = @"

                                                                         ██
                                                                        ██

                    ██╗███╗   ██╗███████╗ ██████╗ ██████╗ ███╗   ███╗ █████╗  ██████╗██╗███████╗    
                    ██║████╗  ██║██╔════╝██╔═══██╗██╔══██╗████╗ ████║██╔══██╗██╔════╝██║██╔════╝    
                    ██║██╔██╗ ██║█████╗  ██║   ██║██████╔╝██╔████╔██║███████║██║     ██║█████╗      
                    ██║██║╚██╗██║██╔══╝  ██║   ██║██╔══██╗██║╚██╔╝██║██╔══██║██║     ██║██╔══╝      
                    ██║██║ ╚████║██║     ╚██████╔╝██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╗██║███████╗    
                    ╚═╝╚═╝  ╚═══╝╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝╚══════╝    
                                                                                ";
                        Console.WriteLine(str);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Vítame vás v tomto receptári :-* ");
                        Console.WriteLine("Nájdete tu plno vynikajúcich receptov rôznych druhov z ktorých si každý vyberie.");
                        Console.WriteLine("Dúfam, že vám budú všetky recepty chutiť <3 ");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Vytvorené T.Michalíkovou a B.Dujčíkovou.");
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
       
                      
                        break;
                    }


                case "u":
                case "U":
                    {
                        Environment.Exit(0);

                        break;
                    }


                default:
                    {

                        Console.Clear();
                        Menu hlavna = new Menu();
                        hlavna.DesignMenu();

                        break;
                    }
            }


        }   
    }
}
