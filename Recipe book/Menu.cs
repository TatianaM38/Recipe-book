﻿using System;

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
                                         --------------------------------------
                                                  ╦═╗┌─┐┌─┐┌─┐┌─┐┌┬┐┬ ┬    
                                              *   ╠╦╝├┤ │  ├┤ ├─┘ │ └┬┘   *        
                                                  ╩╚═└─┘└─┘└─┘┴   ┴  ┴ 
                                         --------------------------------------";
            Console.Write(recepty);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string Edit = @" 
                                     
                                         --------------------------------------
                                                ╦╔═┌─┐┌┬┐┌─┐┌─┐┌─┐┬─┐┬┌─┐
                                            *   ╠╩╗├─┤ │ ├┤ │ ┬│ │├┬┘│├┤    *
                                                ╩ ╩┴ ┴ ┴ └─┘└─┘└─┘┴└─┴└─┘ 
                                         -------------------------------------- ";
            Console.Write(Edit);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                        Console.WriteLine("Vybrali ste r");
                        Console.ReadKey();

                        break;
                     }

                case "k":
                case "K":
                    {
                        Console.WriteLine("Vybrali ste k ");
                        Console.ReadKey();

                        break;
                    }

                case "p":
                case "P":
                    {
                        Console.WriteLine("Vybrali ste p ");
                        Console.ReadKey();

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
