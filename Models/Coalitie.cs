using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Coalitie
    {
        public int ID { get; private set; }
        public string Naam { get; private set; }

        public Coalitie(int id, string naam)
        {
            this.ID = id;
            this.Naam = naam;
        }
    }
}