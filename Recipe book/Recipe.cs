using System;


namespace Recipe_book
{
    class Recipes
    {
        public void RecipeClass() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string rec = @"     
                                   ██████╗ ███████╗ ██████╗███████╗██████╗ ████████╗██╗   ██╗
                                   ██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗╚══██╔══╝╚██╗ ██╔╝
                                   ██████╔╝█████╗  ██║     █████╗  ██████╔╝   ██║    ╚████╔╝ 
                                   ██╔══██╗██╔══╝  ██║     ██╔══╝  ██╔═══╝    ██║     ╚██╔╝  
                                   ██║  ██║███████╗╚██████╗███████╗██║        ██║      ██║   
                                   ╚═╝  ╚═╝╚══════╝ ╚═════╝╚══════╝╚═╝        ╚═╝      ╚═╝                                                                    
                                                   ";
            Console.Write(rec);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*Tu budú recepty*");
            Console.ReadKey();

        }
    }
}
