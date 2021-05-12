using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Album
    {
        public String Name { get; set; }
        private DateTime Date { get; set; }
        private String Image { get; set; }

        public Album(String name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
