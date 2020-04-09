using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library;

namespace WpfBibliothèquedejeux
{
	/// <summary>
	/// Interaction logic for AjoutJeux.xaml
	/// </summary>
	public partial class AjoutJeux : Window
	{
		static StaticTag statictag = new StaticTag();
		public event Action<List<Tag>> AjoutDejeux;
		private RacineTreeView _rtc;

		public AjoutJeux(RacineTreeView racine)
		{
			InitializeComponent();
			LBTag.ItemsSource = statictag.listetag;
			_rtc = racine;
		}

		private void ClickOK(object sender, RoutedEventArgs e)
		{
			//RacineTreeView rtv = new RacineTreeView();
			Jeu jeu = new Jeu(TBName.Text, null, Supportdejeux.PS4);
			foreach (var dlcs in LBDLC.Items)
			{
				DLC dlc = new DLC(dlcs.ToString());
				jeu.Dlc.Add(dlc);
			}

			foreach (var tags in LBTag.SelectedItems)
			{
				Tag tag = _rtc.Tag.Find(x => x.Nom == tags.ToString());
				if (tag == null)
				{
					tag = new Tag(tags.ToString(), null);
					Console.WriteLine(_rtc.ajoutertag(tag));
					//_rtc.ajoutertag(tag);
				}
				tag.ajouterjeu(jeu);
			}
			Close();
		}

		private void ClickCancel(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void ButtonDLCAjouter(object sender, RoutedEventArgs e)
		{
			if(TBDLC.Text != "")
				LBDLC.Items.Add(TBDLC.Text);
			TBDLC.Text = "";
		}
	}
}
