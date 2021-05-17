using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Playlist
    {
        public String Name { get; set; }

        public List<Musique> musiquePlaylist = new List<Musique>();

        public void addMusic(Musique musique)
        {
            musiquePlaylist.Add(musique);
        }

        public void deleteMusic(Musique musique)
        {
            musiquePlaylist.Remove(musique);
        }


    }
}
