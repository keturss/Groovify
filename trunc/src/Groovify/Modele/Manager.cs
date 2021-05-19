using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Manager
    {
        public List<Playlist> ListePlaylists { get; set; } = new List<Playlist>();
        public List<Musique> ListeToutesMusiques { get; set; } = new List<Musique>()
        {
                new Musique { Name="Come Back to Earth", NameArtiste="Mac Miller", NameAlbum="Swimming", Lenght=161, Path="" },
                new Musique { Name="Hurt Feelings", NameArtiste="Mac Miller", NameAlbum="Swimming", Lenght=245, Path="" }
        };
        public Album Swiming { get; set; }
        List<Album> listeAlbumsMacMiller { get; set; } = new List<Album>();
        public Artiste Mac_Miller { get; set; } 
        public Manager() 
        {
            Swiming = new Album { ListeMusique = ListeToutesMusiques };
            listeAlbumsMacMiller.Add(Swiming);
            Mac_Miller = new Artiste("Mac Miller") { ListeAlbum = listeAlbumsMacMiller};
        }
        public bool AjoutePlaylist(Playlist p)
        {
            ListePlaylists.Add(p);
            return true;
        }
        public bool ModifierPlaylist(Playlist p)
        {
            return true;
        }
        public bool SupprimerPlaylist(Playlist p)
        {
            
            return true;
        }

    }
}
