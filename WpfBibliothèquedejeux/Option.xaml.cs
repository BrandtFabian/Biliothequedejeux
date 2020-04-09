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
using Library;

namespace WpfBibliothèquedejeux
{
	/// <summary>
	/// Interaction logic for Option.xaml
	/// </summary>
	public partial class Option : Window
	{
		public enum Valeurretouroption
		{
			Default, OK, Cancel, Apply
		}

		Compte _madata;
		Compte madataretour;

		public event Action<Color, Color> OnColorChange;

		public Option(Compte mydatamodif)
		{
			InitializeComponent();
			madataretour = mydatamodif;
			_madata = new Compte();
			MaDataModif(mydatamodif, _madata);
			GridCurrent.DataContext = _madata;
		}

		public Valeurretouroption resultat = Valeurretouroption.Default;

		private void CANCEL_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void OK_Click(object sender, RoutedEventArgs e)
		{
			resultat = Valeurretouroption.OK;
			MaDataModif(_madata, madataretour);
			OnColorChange?.Invoke(CouleurFond.SelectedColor.Value, CouleurTexte.SelectedColor.Value);
			Close();
		}

		private void APPLY_Click(object sender, RoutedEventArgs e)
		{
			resultat = Valeurretouroption.Apply;
			MaDataModif(_madata, madataretour);
			OnColorChange?.Invoke(CouleurFond.SelectedColor.Value, CouleurTexte.SelectedColor.Value);
		}

		private void MaDataModif(Compte source, Compte destination)
		{
			destination.ColorFond = source.ColorFond;
			destination.ColorText = source.ColorText;
		}
	}
}
