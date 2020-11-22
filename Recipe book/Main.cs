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
                           *                                          _                 _      *       
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
                                         --------------------------------------
                                                  ╦═╗┌─┐┌─┐┌─┐┌─┐┌┬┐┬ ┬    
                                              *   ╠╦╝├┤ │  ├┤ ├─┘ │ └┬┘   *        
                                                  ╩╚═└─┘└─┘└─┘┴   ┴  ┴ 
                                         --------------------------------------";
            Console.Write(recepty);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string Edit = @" 
                                     
                                         --------------------------------------
                                                ╦╔═┌─┐┌┬┐┌─┐┌─┐┌─┐┬─┐┬┌─┐
                                            *   ╠╩╗├─┤ │ ├┤ │ ┬│ │├┬┘│├┤    *
                                                ╩ ╩┴ ┴ ┴ └─┘└─┘└─┘┴└─┴└─┘ 
                                         -------------------------------------- ";
            Console.Write(Edit);


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string add = @"

                                         --------------------------------------
                                          ╔═╗┬─┐┬┌┬┐┌─┐ ┬  ┬─┐┌─┐┌─┐┌─┐┌─┐┌┬┐
                                        * ╠═╝├┬┘│ ││├─┤ │  ├┬┘├┤ │  ├┤ ├─┘ │  *
                                          ╩  ┴└─┴─┴┘┴ ┴└┘  ┴└─└─┘└─┘└─┘┴   ┴  
                                         --------------------------------------

                   ";

            Console.Write(add);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ak chcete prejsť na recepty, stlačte na klávesu 'r' a potvrďte klávesou Enter.");
            Console.WriteLine("                   Ak chcete nájsť recepty podľa kategorie, stlačte na klávesu 'k' a potvrďte klávesou Enter.");
            Console.WriteLine("                   Ak chcete pridať recepty, stlačte na klávesu 'p' a potvrďte klávesou Enter.");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("                   Ak chcete ukončiť aplikáciu stlačte na klávesu 'ctrl' a klávesu 'c' zároveň.");

            

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

                case "k":
                case "K":
                    {
                        Console.Clear();
                        Category cat = new Category();
                        cat.CategoryClass();

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
            

                default:
                    {

                        Console.WriteLine("Vybral si si zlú možnosť");
                        Console.ReadKey();
                        Console.Clear();
                        Menu hlavna = new Menu();
                        hlavna.DesignMenu();

                        break;
                    }
            }


        }   
    }
}
