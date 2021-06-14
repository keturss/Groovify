using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Playlist, contenant toute les informations des playlist et des musiques qui font parties
    /// </summary>
    [DataContract]
    public class Playlist
    {
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public List<Musique> musiquePlaylist = new List<Musique>();

        public void addMusic(Musique musique)
        {
            musiquePlaylist.Add(musique);
        }

        public void deleteMusic(Musique musique)
        {
            musiquePlaylist.Remove(musique);
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
