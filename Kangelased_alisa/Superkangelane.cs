using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased_alisa
{
    class Superkangelane :Kangelane
    {
         private static readonly Random r = new Random();
        private double Osavus;
        public Superkangelane(string Nimi, string Asukoht) : base(Nimi, Asukoht)
        {
            Osavus = r.NextDouble()*(5-1)+1;
        }
        public override int Päästa(int ohustatuid)
        {
            return Convert.ToInt32(ohustatuid * (95 + Osavus) / 100);
        }
        public override string ToString()
        {
            return base.ToString()+$"\nLisaks on ta {Osavus:n2}% võimekam kui tavakangelane.";
        }
    }
}
