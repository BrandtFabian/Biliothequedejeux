using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public class DLC : Commun
	{
		private string _nom;
		
		public string Nom { get => _nom; set => _nom = value; }

		public DLC() : this("Pas de DLC") { }

		public DLC(string nom)
		{
			Nom = nom;
		}
		
		public override string ToString()
		{
			string chaine = base.ToString() + "\nNom : " + Nom;
			return chaine;
		}
	}
}
