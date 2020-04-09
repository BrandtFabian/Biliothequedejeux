using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Compte : Commun
	{
		private string _nom;
		private string _prenom;
		private string _email;
		private DateTime _date;
		private string _cheminimage;
		private string _cheminsauvegarde;

		public string Nom { get => _nom; set => _nom = value; }
		public string Prenom { get => _prenom; set => _prenom = value; }
		public string Email { get => _email; set => _email = value; }
		public DateTime Date { get => _date; set => _date = value; }
		public string Cheminimage { get => _cheminimage; set => _cheminimage = value; }
		public string Cheminsauvegarde { get => _cheminsauvegarde; set => _cheminsauvegarde = value; }

		public Compte() : this("Pas de nom", "Pas de prenom", "Pas d'email", DateTime.Now, "chemin de l image", "chemin de sauvegarde") { }
		public Compte(string nom, string prenom, string email, DateTime date, string cheminimage, string cheminsave)
		{
			Nom = nom;
			Prenom = prenom;
			Email = email;
			Date = date;
			Cheminimage = cheminimage;
			Cheminsauvegarde = cheminsave;
		}

		public override string ToString()
		{
			return base.ToString() + "Nom " + Nom + "\nPrenom " + Prenom + "\nEmail " + Email + "\nDate de creation " + Date + "\nChemin image " + Cheminimage + "\n chemin save " + Cheminsauvegarde;
		}
	}
}
