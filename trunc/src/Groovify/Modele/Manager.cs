using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace Modele
{
    public class Manager
    {
        public ObservableCollection<Playlist> ListePlaylists { get; set; } = new ObservableCollection<Playlist>();
        public List<Artiste> ListeArtiste { get; set; } = new List<Artiste>();



        public List<Musique> ListeToutesMusiques { get; set; } = new List<Musique>()
        {
                new Musique { Name="Come Back to Earth",NameArtiste="salut",NameAlbum="aze", Lenght=161, Path="" },
                new Musique { Name="Hurt Feelings",NameArtiste="salut",NameAlbum="aze", Lenght=245, Path="" }
        };
        public Album Swiming { get; set; }
        List<Album> listeAlbumsMacMiller { get; set; } = new List<Album>();
        public Artiste Mac_Miller { get; set; }
        public Manager()
        {
            Swiming = new Album { ListeMusique = ListeToutesMusiques };
            listeAlbumsMacMiller.Add(Swiming);
            Mac_Miller = new Artiste("Mac Miller") { ListeAlbum = listeAlbumsMacMiller };
        }



        // Gestion Playlist
        public bool AjoutePlaylist(Playlist p)
        {
            if (ListePlaylists.Any(x => x.Name == p.Name))
            {
                ListePlaylists.Add(p);
                return true;
            }
            return false;
        }

        public bool ModifierPlaylist(Playlist p, String name, String newName)
        {
            Playlist trouverPlaylist = ListePlaylists.First(x => x.Name == name);
            trouverPlaylist.Name = newName;
            return true; // les return bool ne servent strictement a rien
        }
        public bool SupprimerPlaylist(Playlist p)
        {
            return ListePlaylists.Remove(p); // ca return un bool
        }


        // Gestion musique (CREEATION)
        public void nouvelleMusique(String name, String nomArtiste, String nomAlbum)
        {
            Artiste chercheArtiste = rechercheArtiste(nomArtiste);
            if (chercheArtiste == null)
            {
                chercheArtiste = new Artiste(nomArtiste);
                ListeArtiste.Add(chercheArtiste);
                Console.WriteLine("Creation artiste");
            }

            Album chercheAlbum = rechercheAlbum(nomAlbum, chercheArtiste);
            if (chercheAlbum == null)
            {
                chercheAlbum = new Album(nomAlbum);
                chercheArtiste.ListeAlbum.Add(chercheAlbum);
                Console.WriteLine("Creation album");
            }

            Musique chercheMusique = rechercheMusique(nomAlbum, chercheAlbum);
            if (chercheMusique == null)
            {
                chercheMusique = new Musique(name);
                chercheAlbum.ListeMusique.Add(chercheMusique);
                Console.WriteLine("Creation Musique");
            }

        }

        // recherche a déplacer dans un interface.
        public Artiste rechercheArtiste(String name)
        {
            if (ListeArtiste.Exists(x => x.Name == name))
            {
                Console.WriteLine("artiste trouvée");
                Artiste trouveArtiste = ListeArtiste.Find(x => x.Name == name);
                return trouveArtiste;
            }
            return null;
        }

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

        public Musique rechercheMusique(String name, Album nomAlbum)
        {
            if (nomAlbum.ListeMusique.Exists(x => x.Name == name))
            {
                Console.WriteLine("musique trouvée");
                Musique trouveMusique = nomAlbum.ListeMusique.Find(x => x.Name == name);
                return trouveMusique;
            }
            return null;
        }

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

