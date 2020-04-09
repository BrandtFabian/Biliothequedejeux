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
	public class RacineTreeView : Commun, INotifyPropertyChanged
	{
		private List<Tag> _tag;
		
		public event PropertyChangedEventHandler PropertyChanged;

		public List<Tag> Tag 
		{ 
			get => _tag;
			set 
			{ 
				_tag = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tag")) ;
			} 
		}

		public RacineTreeView(): this(null) { }
		public RacineTreeView(List<Tag> tag)
		{
			if (tag is null)
				Tag = new List<Tag>();
			else
				Tag = tag;
		}
		public bool ajoutertag(Tag tag)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tag"));
			Console.WriteLine(tag.Nom);
			if (Tag.Exists(x => x.Nom == tag.Nom))
				return false;
			else
			{
				Tag.Add(tag);
				return true;
			}
		}
	}
}
