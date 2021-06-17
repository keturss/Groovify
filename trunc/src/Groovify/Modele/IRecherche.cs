using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Cette Interface ne fonctionne PAS, le probleme réside dans RechercheAll
    /// </summary>
    public interface IRecherche
    {
        /// <summary>
        /// Algorithm permettant la recherche dans une Liste
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        void DoAlgorithm(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists);
    }

    class RechercheInterface
    {

        private IRecherche _strategy = new RechercheMusique();
        public List<Artiste> artistes { get; private set; }
        public List<Album> albums { get; private set; }
        public List<Musique> musiques { get; private set; }
        public List<Playlist> playlists { get; private set; }
        public RechercheInterface()
        { }

        /// <summary>
        /// Constructieur pour une stratégie (Patron de stratégie)
        /// </summary>
        /// <param name="strategy"></param>
        public RechercheInterface(IRecherche strategy)
        {
            this._strategy = strategy;
        }

        /// <summary>
        /// Sélectionne une nouvelle stratégie (Patron de stratégie)
        /// </summary>
        /// <param name="strategy"></param>
        public void SetStrategy(IRecherche strategy)
        {
            this._strategy = strategy;
        }

        /// <summary>
        /// Fonction qui lance la recherche dans toute la mémoire de l'app
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        /// Pour respecter l'interface, il faudrait que l'algorithme utilise les différentes classes
        /// dépendantes de l'interface. Seulement le retour des différentes List<> contenant des classes différentes empéche le bon fonctionnement
        public void RechercheAll(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists)
        {

            this.musiques = new List<Musique>(musiques.Where(a => a.Name.Contains(motRecherché)));
            this.artistes = new List<Artiste>(artistes.Where(a => a.Name.Contains(motRecherché)));
            this.albums = new List<Album>(albums.Where(a => a.Name.Contains(motRecherché)));
            this.playlists = new List<Playlist>(playlists.Where(a => a.Name.Contains(motRecherché)));
        }
    }

    /// <summary>
    /// Recherche les Musiques correspondantes
    /// </summary>
    class RechercheMusique : IRecherche
    {
        public List<Musique> musiques { get; private set; }

        /// <summary>
        /// Recherche dans la Liste Musique
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        public void DoAlgorithm(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists)
        {
            this.musiques = new List<Musique>(musiques.Where(a => a.Name.Contains(motRecherché)));
        }
    }
    /// <summary>
    /// Recherche les Artiste correspondantes
    /// </summary>
    class RechercheArtiste : IRecherche
    {
        public List<Artiste> artistes { get; private set; }

        /// <summary>
        /// Recherche dans la Liste Artiste
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        public void DoAlgorithm(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists)
        {
            this.artistes = new List<Artiste>(artistes.Where(a => a.Name.Contains(motRecherché)));
        }
    }

    /// <summary>
    /// Recherche les Album correspondantes
    /// </summary>
    class RechercheALbum : IRecherche
    {
        public List<Album> albums { get; private set; }

        /// <summary>
        /// Recherche dans la Liste Album
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        public void DoAlgorithm(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists)
        {
            this.albums = new List<Album>(albums.Where(a => a.Name.Contains(motRecherché)));
        }
    }

    /// <summary>
    /// Recherche les Playlist correspondantes
    /// </summary>
    class RecherchePlaylist : IRecherche
    {
        public List<Playlist> playlists { get; private set; }

        /// <summary>
        /// Recherche dans la Liste Playlist
        /// </summary>
        /// <param name="motRecherché">mot saisie par l user</param>
        /// <param name="artistes">List de tout les Artistes</param>
        /// <param name="albums">Liste de tout les Albums</param>
        /// <param name="musiques">Liste de toutes les Musiques</param>
        /// <param name="playlists">Liste de toutes les Playlists</param>
        public void DoAlgorithm(string motRecherché, List<Artiste> artistes, List<Album> albums, List<Musique> musiques, List<Playlist> playlists)
        {
            this.playlists = new List<Playlist>(playlists.Where(a => a.Name.Contains(motRecherché)));
        }
    }
}
