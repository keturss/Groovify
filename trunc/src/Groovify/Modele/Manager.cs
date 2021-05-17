using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Manager
    {
        List<Artiste> ListeArtiste = new List<Artiste>();


        public List<Musique> AllMusic()
        {
            List<Musique> ListeOeuvre = new List<Musique>();
            
            foreach(Artiste aRtiste in ListeArtiste)
            {
                foreach (Album aLbum in ListeAlbum)
                {
                    foreach (Musique mUsique in ListeMusique)
                    {
                        ListeOeuvre.add(mUsique);
                    }
                }
            }
            

            return ListeOeuvre;
        }


        public Artiste rechercheArtiste(string name)
        {

        }
    }
}
