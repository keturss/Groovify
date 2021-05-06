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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Groovify
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

        private void ChangeVueToVueTitres(object sender, RoutedEventArgs e)
        {
            VuePrincipale.Content = new Vues.VueTitres();
        }
        private void ChangeVueToVueAlbum(object sender, RoutedEventArgs e)
        {
            VuePrincipale.Content = new Vues.VueAlbum();
        }
        private void ChangeVueToVueArtiste(object sender, RoutedEventArgs e)
        {
            VuePrincipale.Content = new Vues.VueArtiste();
        }
        private void NewPlaylist(object sender, RoutedEventArgs e)
        {
            popup.NouvellePlaylist newPlaylist = new popup.NouvellePlaylist();
            newPlaylist.Show();
        }
    }
}
