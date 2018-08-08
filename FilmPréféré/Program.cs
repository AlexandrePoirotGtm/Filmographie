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
            List<Film> ListeFilm = new List<Film>();
            List<Genre> ListeGenre = new List<Genre>();
            List<Client> ListeClient = new List<Client>();
            List<Location> ListeLocation = new List<Location>();


            Genre Action = new Genre("Action");
            Film Avengers = new Film();
            Avengers.Nom = "Avengers";
            OutilsMetier.AddGenre(Avengers, Action);
            Avengers.AfficherGenre();

            Client Michel = new Client("Michel", "Chervier");
            Location Lalocation = new Location(DateTime.Parse("10/10/1245"),Michel,Avengers);

            Michel.LaLocation.Add(Lalocation);
            Avengers.addLocation(Lalocation);

            ListeFilm.Add(Avengers);
            ListeClient.Add(Michel);

            OutilsMetier.AfficherLocation(ListeClient, ListeFilm);
            Lalocation.AfficherLocation();
        }
    }

}
