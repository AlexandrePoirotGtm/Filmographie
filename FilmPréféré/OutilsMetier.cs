using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_métier
{
   public  class OutilsMetier
    {
        public void AddGenre(Film film, Genre genre)
        {
            film.addGenre(genre);
            genre.RajouteFilm(film);
        }
    }
}
