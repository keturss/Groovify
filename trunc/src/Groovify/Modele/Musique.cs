using System;
using System.Collections.Generic;
using System.Text;


namespace Modele
{
    class Musique
    {
        public String Name { get; set; }
        public int Lenght { get; set; }
        public String Path { get; set; }
        public DateTime Date { get; set; }
        public String Image { get; set; }
        public String NameAlbum { get; set; }
        public String NameArtiste { get; set; }

        public Musique(String name, int lenght, String path, DateTime date, String nomArtiste, String nomAlbum, List<Artiste> ListeArtiste, List<Album> ListeAlbum)
        {
            Name = name;
            Lenght = lenght;
            Path = path;
            Date = date;


            //ListeAlbum.Find(x => x.Name.Contains(nomAlbum))
            if (ListeAlbum.FindIndex(x => x.Name.Contains(nomAlbum)))
            {

            }
        }

    }

    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            Musique test1 = new Musique("Test", 10, "test", DateTime.Now, "teste");
            Console.WriteLine(test1.Date);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
