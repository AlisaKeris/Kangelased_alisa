using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased_alisa
{
    class Kangelane
    {
		private string _Nimi;
		private string _Asukoht;
		public Kangelane(string Nimi, string Asukoht)
		{
			_Nimi = Nimi;
			_Asukoht = Asukoht;
		}

		public string GetNimi() { return _Nimi; }
		public void SetNimi(string uusNimi) { _Nimi = uusNimi; }
		public string GetAsukoht() { return _Asukoht; }
		public void SetAsukoht(string uusAsukoht) { _Asukoht = uusAsukoht; }

		public virtual int Päästa(int ohustatuid)
		{ return ohustatuid * 95 / 100; }
        public override string ToString()
        {
			return $" {_Nimi} kaitseb linna {_Asukoht}."; 
        }
    }
}


