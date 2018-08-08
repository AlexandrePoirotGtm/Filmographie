using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Film_métier
{
    public class Film
    {
        public string Nom { get; set; }
        public DateTime Durée { get; set; }
        public List<Genre> LesGenre { get; set; }
        public List<Location> LaLocation { get; set; }
        //public Location LaLocation { get; set; }

        public Film()
        {
            List<Genre> Genres = new List<Genre>();
            LesGenre = Genres;
            List<Location> LaLocation = new List<Location>();
            this.LaLocation = LaLocation;
        }

        public void addGenre(Genre genre)
        {
            LesGenre.Add(genre);
        }

        public void AfficherGenre()
        {
            foreach (Genre genre in LesGenre)
            {
                Console.WriteLine(genre.Nom);
            };
        }

        public void addLocation(Location location)
        {
            LaLocation.Add(location);
        }

        //public int GetLocationId()
        //{
        //    return LaLocation.Id;
        //}
    }
}