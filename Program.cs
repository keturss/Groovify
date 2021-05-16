using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Modele.Artiste> ListeArtiste = new List<Modele.Artiste>();
            List<Modele.Album> ListeAlbum = new List<Modele.Album>();

            Console.WriteLine("START");


            ListeAlbum.Add(new Modele.Album { Name = "teste" });
            ListeAlbum.Add(new Modele.Album { Name = "aie" });

            ListeArtiste.Add(new Modele.Artiste { Name = "teste" });


            Modele.Musique test1 = new Modele.Musique("Test", "teste", "teste", ListeArtiste, ListeAlbum);
            Console.WriteLine(test1.Date);



            foreach (Modele.Album aPart in ListeAlbum)
            {
                Console.WriteLine(aPart);
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
