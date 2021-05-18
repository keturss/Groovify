using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Modele;

namespace Groovify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public Manager ElManager => (App.Current as App).managerTest;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ElManager;
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
        public void ChangeVueToVueDetailArtiste()
        {
            VuePrincipale.Content = new Vues.VueDetailArtiste();
        }
        public void ChangeVueToVueDetailAlbum()
        {
            VuePrincipale.Content = new Vues.VueDetailAlbum();
        }
        private void NewPlaylist(object sender, RoutedEventArgs e)
        {
            popup.NouvellePlaylist newPlaylist = new popup.NouvellePlaylist();
            newPlaylist.Show();
            foreach (Playlist playlist in ElManager.ListePlaylists)
            {
                Debug.WriteLine(playlist.Name);
            }
            ListePlaylists.ItemsSource = ElManager.ListePlaylists;
        }
        
    }
}
