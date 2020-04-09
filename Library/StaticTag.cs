using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public class StaticTag
	{
		public enum tagstatic
		{ 
			Action, Aventure, Course, Horreur, RPG, Simulation, Survie
		}

		public ObservableCollection<tagstatic> listetag;

	    public StaticTag()
		{
			listetag = new ObservableCollection<tagstatic>();
			foreach (tagstatic tag in Enum.GetValues(typeof(tagstatic)))
			{
				listetag.Add(tag);
			}
		}
	}
}
