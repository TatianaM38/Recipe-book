using System;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace Recipe_book
{
    class AddRecipe
    {
        public void AddRec()
        {
         
            Console.WriteLine("Zadajte meno receptu: ");
            Console.ReadLine();
            string name = Console.ReadLine();           
            Console.WriteLine("Zadajte dnešný dátum: ");
            string date = Console.ReadLine();
            Console.WriteLine("Zadajte kategorie receptu (Sladký/Slaný , Nízka/Stredá náročnosť): ");
            string categories = Console.ReadLine();
            Console.WriteLine("Zadajte ingrediencie receptu: ");
            string ingr = Console.ReadLine();
            Console.WriteLine("Zadajte postup prípravy receptu :");
            string proc = Console.ReadLine();
            Console.WriteLine("Zadajte meno autora: ");
            string author = Console.ReadLine();


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\Administrátor\\Desktop\\Recipe.xml");
            XElement Recept = new XElement("Recipe",
                new XAttribute("Name", name),
                new XElement("Date", date),
                new XElement("Categories", categories),
                new XElement("Ingredients", ingr),
                new XElement("Process", proc),
                new XElement("Author", author));

            xmlDoc.Save("C:\\Users\\Administrátor\\Desktop\\Recipe.xml");

            Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(date);
            Console.WriteLine(categories);
            Console.WriteLine(ingr);
            Console.WriteLine(proc);
            Console.WriteLine(author);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                  .────────────────────────────────────────────────────────────────.
                  |                [S]  Späť do hlavnej ponuky                     |
                  *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);

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
