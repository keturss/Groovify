using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Modele;

namespace Groovify
{
    /// <summary>
    /// Logique d'interaction pour MusicPlayer.xaml
    /// </summary>
    public partial class MusicPlayer : UserControl
    {
        WMPLib.WindowsMediaPlayer Player;

        public Manager ElManager => (App.Current as App).managerTest;
        private Musique Musique;
        private Album Album;
        bool musiquePlaying = false;

        public MusicPlayer(Musique musique)
        {
            InitializeComponent();
            Textes.DataContext = musique;
            Musique = musique;
            Album = ElManager.rechercheAlbum(Musique.NameAlbum, ElManager.rechercheArtiste(Musique.NameArtiste));
            image_musique.DataContext = Album;
        }

        private void Button_Click_Name(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_NameArtiste(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).ChangeVueToVueDetailArtiste(ElManager.rechercheArtiste(Musique.NameArtiste));
        }
        private void music_player()
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Debug.WriteLine(Musique.Path);
            Player.URL = Musique.Path;
            Player.controls.play();
        }

        private void Play_Pause(object sender, RoutedEventArgs e)
        {
            if (musiquePlaying)
            {
                Player.controls.pause();
                musiquePlaying = false;
            }
            else
            {
                music_player();
                musiquePlaying = true;
            }
        }
    }
}
