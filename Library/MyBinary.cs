using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Library
{
	public class MyBinary
	{
		public static void SaveBin(Compte myMaps, string filename)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			using (Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write,
			FileShare.None))
			{
				binFormat.Serialize(fStream, myMaps);
			}
		}
		public static Compte LoadBin(string filename)
		{
			BinaryFormatter binFormat = new BinaryFormatter();
			using (Stream fstream = File.OpenRead(filename))
			{
				Compte MyCompte = (Compte)binFormat.Deserialize(fstream);
				Console.WriteLine("Fichier bien charger");
				return MyCompte;
			}
		}
	}
}
