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


namespace Groovify.Vues
{
    /// <summary>
    /// Logique d'interaction pour VueTitres.xaml
    /// </summary>
    public partial class VueTitres : UserControl
    {
        public VueTitres()
        {
                        
            InitializeComponent();

            List<Modele.Musique> titres = new List<Modele.Musique>()
            {
                new Modele.Musique { Name="Come Back to Earth", NameArtiste="Mac Miller", NameAlbum="Swimming", Lenght=161, Path="" },
                new Modele.Musique { Name="Hurt Feelings", NameArtiste="Mac Miller", NameAlbum="Swimming", Lenght=245, Path="" }
            };
            
            ListViewSons.ItemsSource = titres;
            //GridViewSons.
        }

        private void ListView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            GridView gridView = listView.View as GridView;

            var width = listView.ActualWidth - SystemParameters.VerticalScrollBarWidth; //utilisé pour obtenir la largeur de la ListView

            var column1 = 0.34;
            var column2 = 0.34;
            var column3 = 0.34; //il faut arrondir au superieur pour pouvoir remplir toute la largeur

            gridView.Columns[0].Width = width * column1;
            gridView.Columns[1].Width = width * column2;
            gridView.Columns[2].Width = width * column3;
        }


    }
}
