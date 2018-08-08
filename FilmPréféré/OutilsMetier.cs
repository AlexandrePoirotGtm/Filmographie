using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_métier
{
   public static class OutilsMetier
    {
        public static void AddGenre(Film film, Genre genre)
        {
            film.addGenre(genre);
            genre.RajouteFilm(film);
        }

        public static void AfficherLocation(List<Client> clients, List<Film> films)
        {
           /* var requete = from client in clients
                          join film in films on client.GetLocationId()
                          equals film.GetLocationId()
                          group client by film into groupe
                          select groupe;

            foreach(var resultat in requete)
            {
                Console.WriteLine(resultat);
            }*/
                  
            


        }
    }
}
