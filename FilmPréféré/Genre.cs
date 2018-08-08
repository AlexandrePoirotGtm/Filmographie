using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_métier
{
    public class Genre
    {
        public string Nom { get; set; }
        public List<Film> ListeFilm { get; set; }

        public Genre(string nom)
        {
            Nom = nom;
            List<Film> Liste = new List<Film>();
            ListeFilm = Liste;
        }

        public void RajouteFilm(Film film)
        {
           ListeFilm.Add(film);
        }

        public void ListFilms()
        {
            foreach(Film leFilm in ListeFilm)
            {
                Console.WriteLine(leFilm.Nom);
            }
        }
    }
}
