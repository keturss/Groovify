using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Manager
    {
        public List<Playlist> ListePlaylists = new List<Playlist>();

        public Manager() 
        {
            Playlist newplaylist = new Playlist { Name = "test" };
            ListePlaylists.Add(newplaylist);
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
