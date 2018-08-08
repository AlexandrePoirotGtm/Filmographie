using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_métier
{
    public class Location
    {
        public DateTime LocationDateMax { get; set; }
        public int Id { get; set; }
        public Client Client { get; set; }
        public Film Film { get; set; }

        public Location(DateTime dateMax,Client client,Film film)
        {
            this.LocationDateMax = dateMax;
            Random rand = new Random(10);
            int id = rand.Next(255);
            Id = id;
            this.Film = film;
            this.Client = client;
        }

        public void AfficherLocation()
        {
            Console.WriteLine(Client.Nom);
            Console.WriteLine(Film.Nom);
            Console.WriteLine(LocationDateMax);
        }
    }
}