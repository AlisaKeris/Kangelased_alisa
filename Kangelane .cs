using System;

public class Kangelane
{
	public Kangelane()
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
	public void SetAsukoht(string uusAsukoht ) { _Asukoht = uusAsukoht; } 

	public int Päästa(int ohustatuid)
	{ return ohustatuid * 95 / 100; }
		

}
}
