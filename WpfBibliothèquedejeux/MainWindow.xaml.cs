using Library;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBibliothèquedejeux
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (TxtName.Text.Length < 1 || Txtfirstame.Text.Length < 1)
                MessageBox.Show("Erreur d'encodage du nom ou du prénom.");
            else
            {
                Compte data = new Compte(TxtName.Text, Txtfirstame.Text, null);

                MyAppParamManager nouvellecle = new MyAppParamManager(TxtName.Text, Txtfirstame.Text);
                DirectoryInfo donnee = new DirectoryInfo(nouvellecle.GetValeur(Registrydata.Chemin));
                try
                {
                    data.Load(donnee);
                    AfficherCarte(data);
                }
                catch
                {
                    MessageBoxResult resultat = MessageBox.Show("Votre profil n'existe pas, voulez vous le créer?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (resultat == MessageBoxResult.Yes)
                    {
                        data.Save(donnee);
                        AfficherCarte(data);
                    }
                }

            }
        }

        private void AfficherCarte(Compte data)
        {
            BibliothèqueWindow applic = new BibliothèqueWindow(data);
            this.Visibility = Visibility.Hidden;
            applic.ShowDialog();
            this.Close();
        }
    }
}
