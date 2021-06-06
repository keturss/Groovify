using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Modele;

namespace DataContractPersistance
{
    class DataContractPers : IPersistance
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//JSON");
        public string FileName { get; set; } = "playlists.json";
        public ObservableCollection<Playlist> ChargeDonnee()
        {
            throw new NotImplementedException();
        }

        public void SauvegardeDonnee(ObservableCollection<Playlist> playlists)
        {
            var serializer = new DataContractJsonSerializer(typeof(Playlist));
            using (Stream s = File.Create(Path.Combine(FilePath, FileName)))
            {

            }
        }
    }
}
