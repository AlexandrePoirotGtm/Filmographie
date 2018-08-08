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

        public static Location CréationLocation(Client client, Film film,string LaDate)
        {
            Location laLocation = new Location(DateTime.Parse(LaDate), client, film);
            client.LaLocation.Add(laLocation);
            film.LaLocation.Add(laLocation);
            return laLocation;
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
