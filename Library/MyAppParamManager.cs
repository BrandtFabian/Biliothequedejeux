using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public enum Registrydata
	{
		Chemin, 
		Jeux, 
		OldPath
	}
	
	public class MyAppParamManager
	{
		public RegistryKey _rk;
		private string _chemin = @"Software\Bibliothèquedejeux\";
		private string _nom = "Nom";
		private string _prenom = "Prenom";

		public string Nom { get => _nom; set => _nom = value; }
		public string Prenom { get => _prenom; set => _prenom = value; }
		public string Chemin { get => _chemin; set => _chemin = value; }

		public MyAppParamManager()
		{
			_rk = Registry.CurrentUser.CreateSubKey(Chemin+Nom+Prenom);
			InitialiserCle();
		}

		public MyAppParamManager(string nom, string prenom)
		{
			Nom = nom;
			Prenom = prenom;
			_rk = Registry.CurrentUser.CreateSubKey(Chemin + Nom + Prenom);
			InitialiserCle();
		}
		
		private void InitialiserCle()
		{
			foreach (Registrydata parametre in Enum.GetValues(typeof(Registrydata)))
			{
				if (_rk.GetValue(parametre.ToString()) == null)
					SetDefault(parametre);
			}
		}

		public void SetValeur(Registrydata param, string valeur)
		{
			_rk.SetValue(param.ToString(), valeur);
		}

		public string GetValeur(Registrydata param)
		{
			if (_rk.GetValue(param.ToString()) == null)
				SetDefault(param);
			return _rk.GetValue(param.ToString()).ToString();
		}

		private void SetDefault(Registrydata param)
		{
			switch (param)
			{
				case Registrydata.Chemin:
					_rk.SetValue(param.ToString(), @"D:\Documents\");
					break;
				case Registrydata.Jeux:
					_rk.SetValue(param.ToString(), "2");
					break;
				case Registrydata.OldPath:
					_rk.SetValue(param.ToString(), @"C:\Documents\");
					break;
			}
		}
	}
}
