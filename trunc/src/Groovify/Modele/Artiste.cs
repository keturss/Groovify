using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Artiste
    {
        public String Name { get; set; }
        private String Description { get; set; }
        private String Image { get; set; }
        public Artiste NameArtiste { get; set; }

        public Artiste(String name)
        {
            Name = name;
        }


    }
}
