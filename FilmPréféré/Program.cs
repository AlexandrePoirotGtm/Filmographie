using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Film_métier
{
    class Program
    {
        static void Main(string[] args)
        {
            OutilsMetier Outils = new OutilsMetier();
            List<Film> ListeFilm = new List<Film>();
            List<Genre> ListeGenre = new List<Genre>();

            Genre Action = new Genre("Action");
            Film Avengers = new Film();
            Avengers.Nom = "Avengers";
            Outils.AddGenre(Avengers,Action);
            
        }
    }
    
}
