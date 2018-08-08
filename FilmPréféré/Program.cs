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
            Film Avengers = new Film("Avengers",TimeSpan.FromMinutes(150));
            Avengers.Nom = "Avengers";
            OutilsMetier.AddGenre(Avengers, Action);
            Avengers.AfficherGenre();

            Client Michel = new Client("Michel", "Chervier");
            Location lalocation = OutilsMetier.CréationLocation(Michel,Avengers,"10/10/2018 18:00:00");

            ListeFilm.Add(Avengers);
            ListeClient.Add(Michel);

            lalocation.AfficherLocation();
            Avengers.AfficherDurée();

            

           /* TimeSpan heure = TimeSpan.FromHours(DateTime.Now.Hour);

            if (heure < TimeSpan.FromHours(18))
            {
                Console.WriteLine("il est en dessous de 18h");
            }
            else if (heure == TimeSpan.FromHours(14))
            {
                Console.WriteLine("il est 18h");
            }
            else if (heure < TimeSpan.FromHours(14))
            {
                Console.WriteLine("il est plus de 18h");
            }*/
        }
    }

}