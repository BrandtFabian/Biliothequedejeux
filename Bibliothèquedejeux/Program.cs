using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Bibliothèquedejeux
{
	class Program
	{
		static void Main(string[] args)
		{
			Compte testcompte = new Compte();
			Jeu testjeu = new Jeu();
			Tag testtag = new Tag();

			Console.WriteLine("TEST CONSTRUCTEUR PAR DEFAUT");
			Console.WriteLine("COMPTE");
			Console.WriteLine(testcompte.ToString());
			Console.WriteLine("JEU");
			Console.WriteLine(testjeu.ToString());
			Console.WriteLine("TAG");
			Console.WriteLine(testtag.ToString());

			Console.WriteLine("TEST LISTE TAG");
			Tag tag1 = new Tag("Aventure");
			Tag tag2 = new Tag("Simulation");
			Tag tag3 = new Tag("Action");
			List<Tag> listetag = new List<Tag>();
			listetag.Add(tag1);
			listetag.Add(tag2);
			listetag.Add(tag3);
			foreach (Tag game in listetag)
			{
				Console.WriteLine(game.ToString());
			}

			Console.WriteLine("TEST LISTE JEU");
			Jeu testjeu2 = new Jeu();
			Jeu jeu1 = new Jeu("Assassin", listetag, Supportdejeux.PC);
			Tag tag4 = new Tag("Action");
			Tag tag5 = new Tag("Course");
			List<Tag> listetag2 = new List<Tag>();
			listetag2.Add(tag4);
			listetag2.Add(tag5);
			Jeu jeu2 = new Jeu("Conan", listetag2, Supportdejeux.PS4);
			Console.WriteLine("----jeu1---------");
			Console.WriteLine(jeu1);
			Console.WriteLine("----jeu2---------");
			Console.WriteLine(jeu2);


			MyAppParamManager nouvellecle = new MyAppParamManager();
			nouvellecle.SetValeur(Registrydata.Chemin , @"C:\Documents\");
			nouvellecle.SetValeur(Registrydata.Jeux, "World War Z");
			Console.ReadKey();
		}
	}
}
