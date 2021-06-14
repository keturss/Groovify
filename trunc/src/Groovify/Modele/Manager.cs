using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace Modele
{
    public class Manager
    {
        public ObservableCollection<Playlist> ListePlaylists { get; set; } = new ObservableCollection<Playlist>();
        public List<Artiste> ListeArtiste { get; set; } = new List<Artiste>();
        public List<Musique> ListeToutesMusiques { get; set; } = new List<Musique>();
        public IPersistance Persistance { get; private set; }
        
        /// <summary>
        /// Démarrage de l'appli par le l'import des fichiers (Musiques,Album,Artiste),chargement des playlists et sauvegarde des playlists
        /// </summary>
        /// <param name="persistance"></param>
        public Manager(IPersistance persistance)
        {
            ImportFichiers();
            Persistance = persistance;
            ListePlaylists= Persistance.ChargeDonnee();
            Persistance.SauvegardeDonnee(ListePlaylists);
        }

        /// <summary>
        /// Import des Musiques, Album, Artiste
        /// </summary>
        private void ImportFichiers()
        {
            DirectoryInfo di = new DirectoryInfo("./Musiques");
            DirectoryInfo[] dirArtistes = di.GetDirectories();
            foreach (DirectoryInfo dirArtiste in dirArtistes)
            {
                DirectoryInfo[] dirAlbums = dirArtiste.GetDirectories();
                Artiste artiste = new Artiste { Name = dirArtiste.Name };
                List<Album> albumsArtiste = new List<Album>();
                //image artiste
                FileInfo[] filesInArtist = dirArtiste.GetFiles();
                foreach (FileInfo fileInfo in filesInArtist)
                {
                    if (fileInfo.Extension == ".jpg")
                    {
                        artiste.Image = fileInfo.FullName;
                    }
                }
                //albums artiste
                foreach (DirectoryInfo dirAlbum in dirAlbums)
                {
                    FileInfo[] fichiers = dirAlbum.GetFiles();
                    Album album = new Album { Name = dirAlbum.Name };
                    List<Musique> musiquesAlbum = new List<Musique>();
                    foreach (FileInfo file in fichiers)
                    {
                        string name = file.Name;
                        name = Path.GetFileNameWithoutExtension(name);
                        name = name.Replace("-", " ").Replace("_", " "); //remplace _ et - par des espaces
                        Debug.WriteLine("DirectoryName : " + file.DirectoryName+ " Extension : " + file.Extension+ " Name : " + name);
                        if (file.Extension==".mp3") //a ajouter : d'autres formats que mp3 si possible
                        {
                            Musique musique = new Musique { Name = name, NameAlbum= dirAlbum.Name, NameArtiste= dirArtiste.Name, Path=file.FullName};
                            musiquesAlbum.Add(musique);
                        }
                        if (file.Extension==".jpg") //a ajouter potentiellement : .png
                        {
                            album.Image = file.FullName;
                            Debug.WriteLine(file.FullName);
                        }
                    }
                    album.ListeMusique = musiquesAlbum;
                    albumsArtiste.Add(album);
                    ListeToutesMusiques.AddRange(musiquesAlbum);
                }
                artiste.ListeAlbum = albumsArtiste;
                ListeArtiste.Add(artiste);
            }
        }

        /// <summary>
        /// Creer une nouvelle playlist
        /// </summary>
        /// <param name="p">Objet playlist a crée</param>
        /// <returns>
        /// Boolean pour la création  ou l'échec la création de la playlist
        /// </returns>
        public bool AjoutePlaylist(Playlist p)
        {
            if (!ListePlaylists.Any(x => x.Name == p.Name))
            {
                ListePlaylists.Add(p);
                return true;
            }
            Debug.WriteLine("On peut pas creer la playlist");
            return false;
        }

        /// <summary>
        /// Supprime une playlist
        /// </summary>
        /// <param name="p">Objet playlist a supprimé</param>
        /// <returns>
        /// Boolean pour reussite ou échec de la suppression</returns>
        public bool SupprimerPlaylist(Playlist p)
        {
            return ListePlaylists.Remove(p);
        }


        //////
        //Ces Méthodes de recherches peuvent être remplacé par l'interface de recherche une fois terminé
        //////
        
   
        /// <summary>
        /// Recherche d'un Artiste dans la liste d'artiste
        /// </summary>
        /// <param name="name">Nom de la recherche</param>
        /// <returns>L'Artiste trouvé</returns>
        public Artiste rechercheArtiste(String name)
        {
            if (ListeArtiste.Exists(x => x.Name == name))
            {
                Artiste trouveArtiste = ListeArtiste.Find(x => x.Name == name);
                return trouveArtiste;
            }
            return null;
        }

        /// <summary>
        /// Recherche d'un Album dans la liste d'artiste
        /// </summary>
        /// <param name="name">Nom de la recherche</param>
        /// <returns>L'Album trouvé</returns>
        public Album rechercheAlbum(String name, Artiste nameArtiste)
        {
            if (nameArtiste.ListeAlbum.Exists(x => x.Name == name))
            {
                Console.WriteLine("album trouvée");
                Album trouveAlbum = nameArtiste.ListeAlbum.Find(x => x.Name == name);
                return trouveAlbum;
            }
            return null;
        }

        /// <summary>
        /// Recherche d'une PLaylist dans la liste d'artiste
        /// </summary>
        /// <param name="name">Nom de la recherche</param>
        /// <returns>Playlist trouvé</returns>
        public Playlist recherchePlaylist(String name)
        {
            if (ListePlaylists.Any(x => x.Name == name))
            {
                Playlist trouvePlaylist = ListePlaylists.First(x => x.Name == name);
                return trouvePlaylist;
            }
            return null;
        }
    }
}

