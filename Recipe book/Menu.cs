using System;

namespace Recipe_book
{
    class Menu 
    {
        public void DesignMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string recepty = @" 
                                       ------------------------
                                         ╦═╗┌─┐┌─┐┌─┐┌─┐┌┬┐┬ ┬    
                                      *  ╠╦╝├┤ │  ├┤ ├─┘ │ └┬┘  *        
                                         ╩╚═└─┘└─┘└─┘┴   ┴  ┴ 
                                       ------------------------";
            Console.Write(recepty);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string Edit = @" 
                                     
                                 --------------------------------------
                                   ╔═╗┌┬┐┬┌┬┐┬ ┬ ┬  ┬─┐┌─┐┌─┐┌─┐┌─┐┌┬┐
                                *  ║╣  │││ │ │ │ │  ├┬┘├┤ │  ├┤ ├─┘ │  *
                                   ╚═╝─┴┘┴ ┴ └─┘└┘  ┴└─└─┘└─┘└─┘┴   ┴ 
                                 -------------------------------------- ";
            Console.Write(Edit);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string add = @"

                                 --------------------------------------
                                  ╔═╗┬─┐┬┌┬┐┌─┐ ┬  ┬─┐┌─┐┌─┐┌─┐┌─┐┌┬┐
                               *  ╠═╝├┬┘│ ││├─┤ │  ├┬┘├┤ │  ├┤ ├─┘ │   *
                                  ╩  ┴└─┴─┴┘┴ ┴└┘  ┴└─└─┘└─┘└─┘┴   ┴  
                                 --------------------------------------

                            ";

            Console.Write(add);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ak chcete prejsť na recepty, kliknite na klávesu 'r'.");
            Console.WriteLine("                            Ak chcete editovať recepty, kliknite na klávesu 'e'.");
            Console.WriteLine("                            Ak chcete pridať recepty, kliknite na klávesu 'p'");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("                            Ak chcete ukončiť aplikáciu 2x kliknite na klávesu Enter");

            Console.ReadLine();

            
        }
    }
}
