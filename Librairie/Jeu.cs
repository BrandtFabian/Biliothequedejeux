using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public enum Supportdejeux
	{ 
		Aucun, PC, Mac, Linux, PS4, XBOX_One, Switch
	}

	public class Jeu : Commun
	{
		private string _nom;
		private List<Tag> _tag;
		private string _support;

		public string Nom { get => _nom; set => _nom = value; }
		internal List<Tag> Tag { get => _tag; set => _tag = value; }
		public string Support { get => _support; set => _support = value; }

		public Jeu() : this("pas de tag", new List<Tag>(), Supportdejeux.Aucun) { }	
		public Jeu(string nom, List<Tag> tag, Supportdejeux supp)
		{
			_nom = nom;
			if (tag != null)
				_tag = tag;
			else
				_tag = new List<Tag>();
			Support = supp.ToString();
		}

		public override string ToString()
		{
			return base.ToString() + "Nom " + Nom + "Tag" + Tag + "Support" + Support;
		}
	}
}
