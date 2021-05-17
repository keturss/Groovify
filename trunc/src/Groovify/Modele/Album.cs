using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Album
    {
        public String Name { get; set; }
        public int Date { get; set; }
        public String Image { get; set; }

        public List<Musique> ListeMusique = new List<Musique>();

        public Album(String name, List<Artiste> ListeArtiste, string nomArtiste)
        {
            Name = name;

            int index = ListeArtiste.FindIndex(x => x.Name == nomArtiste);
            if (index < 0) // Si le nom de l album n'existe pas 
            {
                //Creation de l'album
                ListeArtiste.Add(new Artiste(nomArtiste));
                Console.WriteLine("Creation artiste");
            }
        }

        public Album(){}



        public override string ToString()
        {
            return "Album => Nom : " + Name;
        }
    }
}
