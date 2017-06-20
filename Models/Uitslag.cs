using System;
using System.Collections.Generic;

namespace Models
{
    public class Uitslag
    {
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public DateTime Datum { get; private set; }
        public List<Partij> Partijen { get; private set; } = new List<Partij>();

        public Uitslag(int id, string naam, DateTime datum)
        {
            this.ID = id;
            this.Naam = naam;
            this.Datum = datum;
        }

        public void SetUitslagPartijen(List<Partij> partijen)
        {
            this.Partijen = partijen;
        }
    }
}