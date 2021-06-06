using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Modele;

namespace Stublib
{
    public class Stub : IPersistance
    {
        public ObservableCollection<Playlist> ChargeDonnee()
        {
            return ChargementPlaylist();
            throw new NotImplementedException();
        }

        public void SauvegardeDonnee(ObservableCollection<Playlist> playlists)
        {
            Debug.WriteLine("Sauvegarde");
        }
        private ObservableCollection<Playlist> ChargementPlaylist()
        {
            ObservableCollection<Playlist> playlists = new ObservableCollection<Playlist>();
            playlists.Add(new Playlist() { Name = "Test" });
            return playlists;
        }
    }
}
