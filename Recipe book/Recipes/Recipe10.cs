using System;
using System.Xml;

namespace Recipe_book
{
    class Recipe10
    {
        public void Recept11()
        {
            XmlTextReader xml1 = new XmlTextReader("C:\\Users\\Administrátor\\Desktop\\NewRecipe.xml");
            while (xml1.Read())
            {
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "elevenName")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string s1 = xml1.ReadElementString();
                    Console.WriteLine(s1);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "elevenDate")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string s2 = xml1.ReadElementString();
                    Console.WriteLine("Dátum úpravy: " + s2);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "elevenCat")
                {
                    string s3 = xml1.ReadElementString();
                    Console.WriteLine("Kategórie:" + s3);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "eleveningr")
                {
                    string s4 = xml1.ReadElementString();
                    Console.WriteLine(" Suroviny potrebné na prípravu: ");
                    Console.WriteLine("________________________________");
                    Console.WriteLine(s4);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "elevenproc")
                {
                    string s5 = xml1.ReadElementString();
                    Console.WriteLine(" Postup Prípravy: ");
                    Console.WriteLine("_________________");
                    Console.WriteLine(s5);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "elevenauthor")
                {
                    string s6 = xml1.ReadElementString();
                    Console.WriteLine("Autor receptu: " + s6);
                }

            }

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
