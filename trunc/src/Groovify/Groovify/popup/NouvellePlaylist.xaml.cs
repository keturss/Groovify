using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Groovify.popup
{
    /// <summary>
    /// Logique d'interaction pour NouvellePlaylist.xaml
    /// </summary>
    public partial class NouvellePlaylist : Window
    {
        public NouvellePlaylist()
        {
            InitializeComponent();
        }
        private void ValiderNouvellePlaylist(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AnnulerNouvellePlaylist(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
