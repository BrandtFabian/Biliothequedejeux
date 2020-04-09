using Library;
using System;
using System.Collections.Generic;
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
	/// Interaction logic for Application.xaml
	/// </summary>
	public partial class Application : Window
	{

		private Compte _data;

		public Application()
		{
			InitializeComponent();
		}

		#region CONSTRUCTEUR
		public Application(Compte data)
		{
			InitializeComponent();
			this._data = data;
			//cree la liste des objet
			CarteListeBox.ItemsSource = _data.Observablecollection;
			//initalise les données
			//charge les couleurs
			CarteListeBox.Background = new SolidColorBrush(_data.ColorFond);
			CarteListeBox.Foreground = new SolidColorBrush(_data.ColorText);
			//met les marqueur
		}
		#endregion




	}
}
