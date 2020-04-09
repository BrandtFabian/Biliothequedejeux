using Library;
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

namespace WpfBibliothèquedejeux
{
	/// <summary>
	/// Interaction logic for BibliothèqueWindow.xaml
	/// </summary>
	public partial class BibliothèqueWindow : Window
	{
		private Compte _data;
		RacineTreeView _rtv;
		#region CONSTRUCTEUR
		public BibliothèqueWindow()
		{
			InitializeComponent();
		}
		public BibliothèqueWindow(Compte data)
		{
			InitializeComponent();
			this._data = data;
			//cree la liste des objet
			//CarteListeBox.ItemsSource = _data.Observablecollection;
			//initalise les données
			//charge les couleurs
			//CarteListeBox.Background = new SolidColorBrush(_data.ColorFond);
			//CarteListeBox.Foreground = new SolidColorBrush(_data.ColorText);
			//met les marqueur

			_rtv = new RacineTreeView();
			Tag tag1 = new Tag("Aventure", null);
			Tag tag2 = new Tag("Action", null);
			DLC dlc1 = new DLC("nom du dlc");
			Jeu jeu1 = new Jeu("JeuNum1", null, Supportdejeux.PC);
			jeu1.Dlc.Add(dlc1);
			tag1.Jeux.Add(jeu1);
			_rtv.Tag.Add(tag1);
			_rtv.Tag.Add(tag2);

			UserTreeView.Content = new ControlTreeView(_rtv);
			_rtv.Tag.Add(new Tag());
			_rtv.Tag.Add(new Tag("Tag2", null));
			_rtv.Tag.Add(new Tag("TagdeMerde", null));
		}
		#endregion

		private void Fenetre_OnColorChange(System.Windows.Media.Color arg1, System.Windows.Media.Color arg2)
		{
			UserTreeView.Background = new SolidColorBrush(arg1);
			UserTreeView.Foreground = new SolidColorBrush(arg2);
		}

		private void Fenetre_AjoutDeJeux(List<Tag> listetag)
		{
			foreach (Tag tag in listetag)
			{
				_rtv.ajoutertag(tag);
			}
		}

		private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
		{

		}

		private void MenuItemSave_Click(object sender, RoutedEventArgs e)
		{

		}

		private void MenuItemExit_Click(object sender, RoutedEventArgs e)
		{

		}

		private void menuClick_Option(object sender, RoutedEventArgs e)
		{
			Option fenetre = new Option(_data);
			//abonner evenement option
			fenetre.OnColorChange += Fenetre_OnColorChange;
			fenetre.Show();
		}

		private void menuClick_About(object sender, RoutedEventArgs e)
		{

		}

		private void MenuItemAddGame_Click(object sender, RoutedEventArgs e)
		{
			AjoutJeux fenetre = new AjoutJeux(_rtv);
			//abonner evenement option
			fenetre.AjoutDejeux += Fenetre_AjoutDeJeux;
			fenetre.ShowDialog();

		}
	}



}
