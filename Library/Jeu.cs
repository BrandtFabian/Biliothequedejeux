using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public enum Supportdejeux
	{ 
		Aucun, PC, Mac, Linux, PS4, XBOX_One, Switch
	}

	[Serializable]
	public class Jeu : Commun
	{
		private string _nom;
		private string _support;
		private List<DLC> _dlc;

		public string Nom { get => _nom; set => _nom = value; }
		public string Support { get => _support; set => _support = value; }
		public List<DLC> Dlc { get => _dlc; set => _dlc = value; }

		public Jeu() : this("pas de tag", null, Supportdejeux.Aucun) { }	
		public Jeu(string nom, List<DLC> dlc, Supportdejeux supp)
		{
			_nom = nom;
			if (dlc != null)
				_dlc = dlc;
			else
				_dlc = new List<DLC>();
			Support = supp.ToString();
		}

		public override string ToString()
		{
			string chaine = base.ToString() + "\nNom : " + Nom + "\nSupport : " + Support + "\nTag : ";
			if (!Dlc.Any())
				chaine += "Aucun Tag";
			else
			{
				foreach (DLC dlc in Dlc)
				{
					chaine += ("\t - " + dlc.ToString());
				}
			}
			return chaine;
		}
	}
}
