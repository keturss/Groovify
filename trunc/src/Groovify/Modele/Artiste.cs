using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Artiste, contenant toutes les informations des Artistes
    /// </summary>
    public class Artiste
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }

        public List<Album> ListeAlbum { get; set; } = new List<Album>();

        public Artiste(String name)
        {
            Name = name;
        }

        public Artiste() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
