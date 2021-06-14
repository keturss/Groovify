using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Interface de Persistance des données, chargement et sauvegarde
    /// </summary>
    public interface IPersistance
    {
        /// <summary>
        /// Chargment des playlists grace au format JSON
        /// </summary>
        /// <returns>
        /// retourne la liste des Playlists chargés
        /// </returns>
        ObservableCollection<Playlist> ChargeDonnee();

        /// <summary>
        /// Sauvegardes des playlists sous format JSON
        /// </summary>
        /// <param name="playlists">Liste des Playlist (contentant la liste des Musiques)</param>
        void SauvegardeDonnee(ObservableCollection<Playlist> playlists);
    }
}
