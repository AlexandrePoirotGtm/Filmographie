using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Film_métier;
namespace Film_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> ListeFilm = new List<Film>();
            List<Genre> ListeGenre = new List<Genre>();
            List<Client> ListeClient = new List<Client>();
            List<Location> ListeLocation = new List<Location>();

            Client lala = new Client("George","Doggo","toutou");
            ListeClient.Add(lala);
            OutilsConsole.AfficherLogger(ListeClient);

            foreach(Client cli in ListeClient)
            {
                OutilsConsole.AfficherMessage(cli.Prenom,ConsoleColor.DarkCyan);
            }
        }
    }
}
