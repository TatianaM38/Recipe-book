﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Recipe_book
{
    class Recipe7
    {
        public void Recept7() 
        {
            XmlTextReader xml0 = new XmlTextReader("C:\\Users\\Administrátor\\Desktop\\RecipeStorage.xml");
            while (xml0.Read())
            {
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigname")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    string s1 = xml0.ReadElementString();
                    Console.WriteLine("                                           " + s1);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigdate")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string s2 = xml0.ReadElementString();
                    Console.WriteLine(s2);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigcategory")
                {
                    Console.WriteLine("");
                    string s3 = xml0.ReadElementString();
                    Console.WriteLine(s3);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigingredients")
                {
                    string s4 = xml0.ReadElementString();
                    Console.WriteLine(s4);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigprocess")
                {
                    string s5 = xml0.ReadElementString();
                    Console.WriteLine("Postup prípravy: " + s5);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigauthor")
                {
                    Console.WriteLine("");
                    string s6 = xml0.ReadElementString();
                    Console.WriteLine("Autor receptu: " + s6);
                }
                if (xml0.NodeType == XmlNodeType.Element && xml0.Name == "eigrating")
                {
                    Console.WriteLine("");
                    string s7 = xml0.ReadElementString();
                    Console.WriteLine("Ohodnoťte recept: " + s7);
                }
            }
        }
    }
}
