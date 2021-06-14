using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Modele
{
    /// <summary>
    /// Classe Musique, contenant toute les informations des musiques
    /// </summary>
    [DataContract]
    public class Musique
    {

        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Path { get; set; }
        [DataMember]
        public String NameArtiste { get; set; }
        [DataMember]
        public String NameAlbum { get; set; }


        public Musique(String name)
        {
            Name = name;
        }
        public Musique() { }

        public override string ToString()
        {
            return Name;
        }
    }



    

    
}
