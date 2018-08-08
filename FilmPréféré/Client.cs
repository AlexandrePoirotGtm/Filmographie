using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_métier
{
    class Client
    {
        public string Nom{get;set;}
        public string Prenom{get;set;}
        public string Id{get;set;}
        public List<Location> LaLocation { get; set; }
    }
}
