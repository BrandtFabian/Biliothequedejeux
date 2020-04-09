using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media;

namespace Library
{
	[Serializable]
	public class Compte : Commun
	{
		#region VARIABLE MEMBRE
		private string _nom;
		private string _prenom;
		private string _email;
		private DateTime _date;
		private string _cheminimage;
		private ObservableCollection<Jeu> _observablecollection;
		private string _couleurfond;
		private string _couleurtexte;
		#endregion
		
		#region PROPRIETE
		public string Nom { get => _nom; set => _nom = value; }
		public string Prenom { get => _prenom; set => _prenom = value; }
		public string Email { get => _email; set => _email = value; }
		public DateTime Date { get => _date; set => _date = value; }
		public string Cheminimage { get => _cheminimage; set => _cheminimage = value; }
		public ObservableCollection<Jeu> Observablecollection { get => _observablecollection; set => _observablecollection = value; }
		public Color ColorFond
		{
			get
			{
				if (_couleurfond != null)
				{
					Color tmp = (Color)ColorConverter.ConvertFromString(_couleurfond);
					return tmp;
				}
				else
				{
					return Colors.Black;
				}
			}
			set
			{
				_couleurfond = value.ToString();
			}
		}
		public Color ColorText
		{
			get
			{
				if (_couleurtexte != null)
				{
					Color tmp = (Color)ColorConverter.ConvertFromString(_couleurtexte);
					return tmp;
				}
				else
				{
					return Colors.White;
				}
			}
			set
			{
				_couleurtexte = value.ToString();
			}
		}
		#endregion

		#region CONSTRUCTEUR
		public Compte() : this("Pas de nom", "Pas de prenom", null) { }
		public Compte(string nom, string prenom, ObservableCollection<Jeu> liste)
		{
			Nom = nom;
			Prenom = prenom;
			if (liste != null)
				Observablecollection = liste;
			else
				Observablecollection = new ObservableCollection<Jeu>();
		}
		#endregion

		#region METHODE
		public override string ToString()
		{
			return base.ToString() + "\nNom : " + Nom + "\nPrenom : " + Prenom + "\nEmail : " + Email + "\nDate de creation : " + Date + "\nChemin image : " + Cheminimage;
		}
		public void Save(DirectoryInfo dirname)
		{
			string chemindacces = dirname.FullName + Nom + Prenom;
			MyBinary.SaveBin(this, chemindacces);
		}
		public void Load(DirectoryInfo dirname)
		{
			string chemindacces = dirname.FullName + Nom + Prenom;
			Compte data = MyBinary.LoadBin(chemindacces);
			this.Nom = data.Nom;
			this.Prenom = data.Prenom;
			this.Email = data.Email;
			this.Date = data.Date;
			this.Observablecollection = data.Observablecollection;
			this.Cheminimage = data.Cheminimage;
			this.ColorFond = data.ColorFond;
			this.ColorText = data.ColorText;
		}
		#endregion
	}
}
