using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Film_métier
{
    public class Client
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Id { get; set; }
        public List<Location> LaLocation { get; set; }

        public Client(string prenom,string nom)
        {
            Prenom = prenom;
            Nom = nom;
            Random rand = new Random(10);
            int id = rand.Next(255);
            Id = id;
            List<Location> LaLocation = new List<Location>();
            this.LaLocation = LaLocation;
        }

       /* public int GetLocationId()
        {
            //return LaLocation.Id;
        }*/
    }
}
