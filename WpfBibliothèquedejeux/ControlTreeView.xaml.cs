using Library;
using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBibliothèquedejeux
{
    /// <summary>
    /// Interaction logic for ControlTreeView.xaml
    /// </summary>
    public partial class ControlTreeView : UserControl
    {
        RacineTreeView _rtv;
        public ControlTreeView()
        {  
            InitializeComponent();
            RacineTreeView rtv = new RacineTreeView();
            _rtv = rtv;
            Tag tag1 = new Tag("Aventure", null);
            Tag tag2 = new Tag("Action", null);
            DLC dlc1 = new DLC("nom du dlc");
            Jeu jeu1 = new Jeu("JeuNum1", null, Supportdejeux.PC);
            jeu1.Dlc.Add(dlc1);
            tag1.Jeux.Add(jeu1);
            rtv.Tag.Add(tag1);
            rtv.Tag.Add(tag2);

            this.DataContext = _rtv;
        }

        public ControlTreeView(RacineTreeView rtv2)
        {
            InitializeComponent();
            _rtv = rtv2;
            this.DataContext = _rtv;
        }

        private void okButton(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
            this.DataContext = _rtv;
        }
    }
}