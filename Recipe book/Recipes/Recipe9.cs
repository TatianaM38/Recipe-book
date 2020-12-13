using System;
using System.IO;
using System.Xml;

namespace Recipe_book
{
    class Recipe9
    {
        public void Recept9() 
        {
            XmlTextReader xml0 = new XmlTextReader("C:\\Users\\Administrátor\\Desktop\\RecipeStorage.xml");
            while (xml0.Read())
            {
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenName")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string s1 = xml0.ReadElementString();
                    Console.WriteLine("                                           " + s1);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenDate")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string s2 = xml0.ReadElementString();
                    Console.WriteLine(s2);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenCategory")
                {
                    Console.WriteLine("");
                    string s3 = xml0.ReadElementString();
                    Console.WriteLine(s3);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenIngredients")
                {
                    string s4 = xml0.ReadElementString();
                    Console.WriteLine(s4);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenProcess")
                {
                    string s5 = xml0.ReadElementString();
                    Console.WriteLine(s5);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "tenAuthor")
                {
                    Console.WriteLine("");
                    string s6 = xml0.ReadElementString();
                    Console.WriteLine("Autor receptu: " + s6);
                }
               
            }

            Console.ReadLine();
            int avg;
            string filename = ("C:\\Users\\Administrátor\\Desktop\\R.xml");
            string[] readText = File.ReadAllLines(filename);
            string[] write = new string[1];
            Console.WriteLine("Ohodnoťte recept 1-5 : ");
            int str = Convert.ToInt32(Console.ReadLine());
            int old = Convert.ToInt32(readText[0]);
            avg = (str + old) / 2;
            write[0] = avg.ToString();
            File.WriteAllLines(filename, write);
            Console.WriteLine(str);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                  .────────────────────────────────────────────────────────────────.
                  |                      [S]  Späť na recepty                      |
                  *────────────────────────────────────────────────────────────────* ";
            Console.WriteLine(s);

            char button1 = Convert.ToChar(Console.Read());
            string buttonString1 = button1.ToString();
            if (buttonString1 == "S")
            {
                Console.Clear();
                Recipes recipes = new Recipes();
                recipes.RecipeClass();
            }
            else if (buttonString1 == "s")
            {
                Console.Clear();
                Recipes recipes = new Recipes();
                recipes.RecipeClass();
            }

        }
    }
}
