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

        public Uitslag(string naam, DateTime datum)
        {
            this.Naam = naam;
            this.Datum = datum;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public void SetUitslagPartijen(List<Partij> partijen)
        {
            this.Partijen = partijen;
        }

        public override string ToString()
        {
            return Naam + "   -   Datum: " + Datum.ToString("dd-MM-yyyy");
        }
    }
}