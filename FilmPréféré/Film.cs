using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Film_métier
{
    public class Film
    {
        public string Nom{get;set;}
        public DateTime Durée{get;set;}
        public List<Genre> LesGenre { get; set; }
        public List<Location> LaLocation { get; set; }

        public Film()
        {
             List <Genre> Genres = new List<Genre>();
            LesGenre = Genres;
            List <Location> LaLocation = new List<Location>();
        }

        public void addGenre(Genre genre)
        {
            LesGenre.Add(genre);
        }
    }
}