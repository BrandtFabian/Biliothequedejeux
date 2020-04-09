using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public class Tag : Commun, INotifyPropertyChanged
	{
		private string _nom;
		private List<Jeu> _jeu;
		public event PropertyChangedEventHandler PropertyChanged;

		public string Nom { get => _nom; set => _nom = value; }
		public List<Jeu> Jeux { get => _jeu; set => _jeu = value; }

		public Tag() : this("Pas de tag", null) { }
		public Tag(string nom, List<Jeu> jeu)
		{
			Nom = nom;
			if (jeu != null)
				Jeux = jeu;
			else
				Jeux = new List<Jeu>();
		}
		public bool ajouterjeu(Jeu jeu)
		{
			this.Jeux.Add(jeu);
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jeux"));
			return true;
		}
		public override string ToString()
		{
			return Nom;
		}
	}
}
