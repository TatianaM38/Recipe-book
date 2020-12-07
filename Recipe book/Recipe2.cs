﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Recipe_book
{
    class Recipe2
    {
        public void Recept2() 
        {
            XmlTextReader xml1 = new XmlTextReader("C:\\Users\\Administrátor\\Desktop\\RecipeStorage.xml");
            while (xml1.Read())
            {
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdname")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string s1 = xml1.ReadElementString();
                    Console.WriteLine("                                           " + s1);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirddate")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string s2 = xml1.ReadElementString();
                    Console.WriteLine(s2);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdcategory")
                {
                    Console.WriteLine("");
                    string s3 = xml1.ReadElementString();
                    Console.WriteLine(s3);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdingredients")
                {
                    string s4 = xml1.ReadElementString();
                    Console.WriteLine(s4);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdprocess")
                {
                    string s5 = xml1.ReadElementString();
                    Console.WriteLine(s5);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdauthor")
                {
                    Console.WriteLine("");
                    string s6 = xml1.ReadElementString();
                    Console.WriteLine("Autor receptu: " + s6);
                }
                if (xml1.NodeType == XmlNodeType.Element && xml1.Name == "thirdrating")
                {
                    Console.WriteLine("");
                    string s7 = xml1.ReadElementString();
                    Console.WriteLine("Ohodnoťte recept: " + s7);
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

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string s = @"

                  .────────────────────────────────────────────────────────────────.
                  |                      [S]  Späť na recepty                      |
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
