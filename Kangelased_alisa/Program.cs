using System;
using System.Collections.Generic;
using System.IO;

namespace Kangelased_alisa
{
    class Program
    {
        static List<Kangelane> kangelased;
        static void LaeKangelased(string failinimi)
        {
            //Console.WriteLine(File.ReadAllText(failinimi));
            var kangelasedfailis = File.ReadAllLines(failinimi);
            foreach(var kangelaseKirja in kangelasedfailis)
            {
                var nimiAsukoht = kangelaseKirja.Split("/");
                if (true)
                {

                }
                Console.WriteLine(nimiAsukoht[0]);
                Console.WriteLine(nimiAsukoht[1]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Superkangelane superman = new Superkangelane("Superman", "Smallville");
            int sajast = superman.Päästa(100);
            int poolsajast = superman.Päästa(50);
            Console.WriteLine(superman);
            Console.WriteLine($"Sajast:{sajast}");
            Console.WriteLine($"Viiekümnest:{poolsajast}");
            LaeKangelased("kangelased.txt");
        }

    
    }
}
