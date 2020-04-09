using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public abstract class Commun
	{
		#region VARIABLE MEMBRE
		private int _id;
		#endregion

		#region PROPRIETE
		public int Id { get => _id; set => _id = value; }
		#endregion

		#region CONSTRUCTEUR
		public Commun() : this(0) {}
		public Commun(int id)
		{
			Id = id;
		}

		public override string ToString()
		{
			return "Id : " + Id;
		}
		#endregion
	}
}
