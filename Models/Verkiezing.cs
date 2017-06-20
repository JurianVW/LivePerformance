using System.Collections.Generic;

namespace Models
{
    public class Verkiezing
    {
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public int Zetels { get; private set; }
        public int ZetelsMeerderheid { get; private set; }

        public List<Partij> Partijen { get; private set; } = new List<Partij>();
        public List<Uitslag> Uitslagen { get; private set; } = new List<Uitslag>();

        public Verkiezing(string naam, int zetels, int zetelsMeerderheid)
        {
            this.Naam = naam;
            this.Zetels = zetels;
            this.ZetelsMeerderheid = zetelsMeerderheid;
        }

        public void SetVerkiezingPartijen(List<Partij> partijen)
        {
            this.Partijen = partijen;
        }

        public void SetVerkiezingUitslagen(List<Uitslag> uitslagen)
        {
            this.Uitslagen = uitslagen;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}