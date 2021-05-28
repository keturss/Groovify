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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Groovify
{
    /// <summary>
    /// Logique d'interaction pour SearchBar.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }
        
        private void barreRecherche_TextChanged(object sender, TextChangedEventArgs e)
        {
            popupResultats.IsOpen = true;
        }

        private void barreRecherche_LostFocus(object sender, RoutedEventArgs e)
        {
            popupResultats.IsOpen = false;
        }
    }
}
