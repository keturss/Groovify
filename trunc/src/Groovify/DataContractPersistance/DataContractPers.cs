using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Modele;

namespace DataContractPersistance
{
    /// <summary>
    /// Sauvegarde des Playlists sous .JSON
    /// </summary>
    public class DataContractPers : IPersistance
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "JSON");
        public string FileName { get; set; } = "playlists.json";

        /// <summary>
        /// Sauvegarde les playlists dans le bon repertoir sous Json
        /// </summary>
        /// <param name="playlists">Liste (ObservableCollection) de Playlist a sauvegardé</param>
        public void SauvegardeDonnee(ObservableCollection<Playlist> playlists)
        {
            var serializer = new DataContractJsonSerializer(typeof(ObservableCollection<Playlist>));
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            using (Stream s = File.Create(Path.Combine(FilePath, FileName)))
            {
                serializer.WriteObject(s, playlists);
            }
            Debug.WriteLine("donnees saved");
        }

        /// <summary>
        /// Charge les playlists précedement crée sous format Json
        /// </summary>
        /// <returns>
        /// La liste (ObservableCollection) de playlist chargée
        /// </returns>
        public ObservableCollection<Playlist> ChargeDonnee()
        {
            if (!Directory.Exists(FilePath))
            {
                //throw new FileNotFoundException("le fichier est manquant");
                Directory.CreateDirectory(FilePath);
            }
            var serializer = new DataContractJsonSerializer(typeof(ObservableCollection<Playlist>));
            if (!File.Exists(Path.Combine(FilePath, FileName)))
            {
                //throw new FileNotFoundException("le json est manquant");
                SauvegardeDonnee(new ObservableCollection<Playlist>());
            }
            ObservableCollection<Playlist> playlists;
            
            using (Stream s = File.OpenRead(Path.Combine(FilePath, FileName)))
            {
                playlists = serializer.ReadObject(s) as ObservableCollection<Playlist>;
            }
            return playlists;
        }
    }
}
