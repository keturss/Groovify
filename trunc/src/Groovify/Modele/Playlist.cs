using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Playlist
    {
        private String Name { get; set; }
        private List<Musique> musiquePlaylist = new List<Musique>();

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
