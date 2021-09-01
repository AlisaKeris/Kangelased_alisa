using System;
using System.Collections.Generic;
using System.IO;

namespace Kangelased_alisa
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();
        static void LaeKangelased(string failinimi)
        {
            //Console.WriteLine(File.ReadAllText(failinimi));
            foreach (var kangelaseKirje in File.ReadAllLines(failinimi))
            {
                var nimiAsukoht = kangelaseKirje.Split("/");
                if (nimiAsukoht[0].EndsWith("*"))
                {
                    kangelased.Add(new Superkangelane(nimiAsukoht[0].Substring(nimiAsukoht[0].Length-1),nimiAsukoht[1]));
                } else
                {
                    kangelased.Add(new Kangelane(nimiAsukoht[0],nimiAsukoht[1]));
                }
                Console.WriteLine(nimiAsukoht[0]);
                Console.WriteLine(nimiAsukoht[1]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            /*Superkangelane superman = new Superkangelane("Superman", "Smallville");
            int sajast = superman.Päästa(100);
            int poolsajast = superman.Päästa(50);
            Console.WriteLine(superman);
            Console.WriteLine($"Sajast:{sajast}");
            Console.WriteLine($"Viiekümnest:{poolsajast}");*/
            LaeKangelased("kangelased.txt");
            Console.WriteLine("Mitu inimest on ohus?");
            var ohus = int.Parse(Console.ReadLine());
            foreach (var kangelane in kangelased)
            {
                Console.WriteLine(kangelane);
                var päästetuid = kangelane.Päästa(ohus);
                Console.WriteLine($"{kangelane.GetNimi()} suutis päästa {ohus}/{päästetuid}.");
            }
        }

    
    }
}
