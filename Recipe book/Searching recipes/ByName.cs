using System;
using System.Linq;

namespace Recipe_book
{
    class ByName
    {
        public void SearchName()
        {
            string[] first = { "tiramisu", "talianske" };
            string[] sec = { "cestoviny", "alfredo", "cestoviny s kuracimi prsiami", "kuracimi prsiami" };
            string[] third = { "karamelovy cheesecake" , "karamelovy" , "cheesecake", "s cokoladou" };
            string[] fou = {"polesniky", "pole" };
            string[] fif = { "kuraci perkelt", "kuraci", "perkelt", "s haluskami", "perkelt s haluskami"};
            string[] six = { "bananove lievance", "bananove", "lievance", "lievance s cokoladou" };
            string[] sev = { "gyros", "v tortille", "tortilla", "gyros s kuracim masom" };
            string[] eig = { "cokoladove", "cookies" };
            string[] nin = {"cokoladova", "cokoladova torta", "torta", "torta s jahodami", "s jahodami"};
            string[] ten = { "pirohy", "zemiakove pirohy", "zemiakove", "s masovou plnkou", "pirohy s masovou plnkou" };

            Console.ReadLine();
            Console.WriteLine("Zadajte časť názvu recepta, ktorý hľadáte malými písmenami bez diakritiky : ");
            string str = Console.ReadLine();


            char button1 = Convert.ToChar(Console.Read());
            string buttonString1 = button1.ToString();

            if (first.Contains(str))
            {
                Console.Clear();
                Recipe0 recipe0 = new Recipe0();
                recipe0.Recept0();
            }
            else if (sec.Contains(str))
            {
                Console.Clear();
                Recipe1 recipe1 = new Recipe1();
                recipe1.Recept1();
            }
            else if (third.Contains(str))
            {
                Console.Clear();
                Recipe2 recipe2 = new Recipe2();
                recipe2.Recept2();

            }
            else if (fou.Contains(str))
            {
                Console.Clear();
                Recipe3 recipe3 = new Recipe3();
                recipe3.Recept3();

            }
            else if (fif.Contains(str))
            {
                Console.Clear();
                Recipe4 recipe4 = new Recipe4();
                recipe4.Recept4();

            }
            else if (six.Contains(str))
            {
                Console.Clear();
                Recipe5 recipe5 = new Recipe5();
                recipe5.Recept5();

            }
            else if (sev.Contains(str))
            {
                Console.Clear();
                Recipe6 recipe6 = new Recipe6();
                recipe6.Recept6();

            }
            else if (eig.Contains(str))
            {
                Console.Clear();
                Recipe7 recipe7 = new Recipe7();
                recipe7.Recept7();

            }
            else if (nin.Contains(str))
            {
                Console.Clear();
                Recipe8 recipe8 = new Recipe8();
                recipe8.Recept8();

            }
            else if (ten.Contains(str))
            {
                Console.Clear();
                Recipe9 recipe9 = new Recipe9();
                recipe9.Recept9();

            }
            else if (buttonString1 == "s")
            {
                Console.Clear();
                Find find = new Find();
                find.FindRecipe();
            }
            else
            {
                Console.Clear();
                ByName byName = new ByName();
                byName.SearchName();
            }


        }
    }
}