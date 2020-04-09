using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Tag : Commun
	{
		private string _nom;

		public string Nom { get => _nom; set => _nom = value; }

		public Tag() : this("Pas de tag") { }
		public Tag(string nom)
		{
			Nom = nom;
		}

	}
}
