using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Album, contenant les informations des albums
    /// </summary>
    public class Album
    {
        public String Name { get; set; }
        public String Image { get; set; }

        public List<Musique> ListeMusique { get; set; } = new List<Musique>();

        public Album(String name)
        {
            Name = name;
        }

        public Album(){}

        public override string ToString()
        {
            return Name;
        }
    }
}
