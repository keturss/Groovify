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

        public Musique(String name)
        {
            Name = name;
        }
        public Musique() { }

        public override string ToString()
        {
            return "Musique => Nom : " + Name;
        }
    }



    

    
}
