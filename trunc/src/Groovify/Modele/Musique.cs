using System;
using System.Collections.Generic;
using System.Text;


namespace Modele
{
    public class Musique
    {
        public String Name { get; set; }
        public int Lenght { get; set; }
        public String Path { get; set; }
        public DateTime Date { get; set; }
        public String NameAlbum { get; set; }
        public String NameArtiste { get; set; }

        public Musique(String name, String nomArtiste, String nomAlbum, List<Artiste> ListeArtiste, List<Album> ListeAlbum)
        {
            Name = name;
            NameAlbum = nomAlbum;
            NameArtiste = nomArtiste;


            int index = ListeAlbum.FindIndex(x => x.Name == nomAlbum);
            if (index < 0) // Si le nom de l album n'existe pas 
            {
                //Creation de l'album
                ListeAlbum.Add(new Album(nomAlbum,ListeArtiste, nomArtiste));
                Console.WriteLine("Creation Album");
            }
        }
        public Musique() { }

        public override string ToString()
        {
            return "Musique => Nom : " + Name;
        }
    }



    

    
}
