using System;
using System.Xml;

namespace Recipe_book
{
    class AddRecipe
    {
        public void AddRec()
        {

            string filename = "C:\\Users\\Administrátor\\Desktop\\NewRecipe.xml";
            XmlTextWriter xmlTextWriter = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("Recept11");
        
            
                xmlTextWriter.WriteStartElement("Recept");

                Console.WriteLine("Zadajte názov receptu: ");
                xmlTextWriter.WriteElementString("elevenName", Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Zadajte dnešný dátum: ");
                xmlTextWriter.WriteElementString("elevenDate", Console.ReadLine());

                Console.WriteLine("Zadajte kategorie receptu (Sladký/Slaný , Nízka/Stredá náročnosť): ");
                xmlTextWriter.WriteElementString("elevenCat", Console.ReadLine());

                Console.WriteLine("Zadajte ingrediencie receptu: ");
                xmlTextWriter.WriteElementString("eleveningr", Console.ReadLine());

                Console.WriteLine("Zadajte postup prípravy: ");
                xmlTextWriter.WriteElementString("elevenproc", Console.ReadLine());

                Console.WriteLine("Zadajte meno autora: ");
                xmlTextWriter.WriteElementString("elevenauthor", Console.ReadLine());

            
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();


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
