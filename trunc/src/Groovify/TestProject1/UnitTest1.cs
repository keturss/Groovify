using System;
using Xunit;
using Modele;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestArtiste()
        {
            Manager a = new Manager(new DataContractPersistance.DataContractPers());

            Assert.True(a.ListeArtiste.Exists(x => x.Name == "Mac Miller"));
            Assert.False(a.ListeArtiste.Exists(x => x.Name == "John"));

        }

        [Fact]
        public void TestAlbum()
        {
            Manager a = new Manager(new DataContractPersistance.DataContractPers());
            List<Album> ListAllAlbums = new List<Album>();

            foreach (Artiste artiste in a.ListeArtiste)
            {
                ListAllAlbums.AddRange(artiste.ListeAlbum);
            }

            Assert.True(ListAllAlbums.Exists(x => x.Name == "Swimming"));
            Assert.False(ListAllAlbums.Exists(x => x.Name == "John"));

        }

        [Fact]
        public void TestMusique()
        {
            Manager a = new Manager(new DataContractPersistance.DataContractPers());

            Assert.True(a.ListeToutesMusiques.Exists(x => x.Name == "come back to earth"));
            Assert.False(a.ListeToutesMusiques.Exists(x => x.Name == "John"));

        }
    }
}
