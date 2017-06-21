using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Database;

namespace Repository.Logic
{
    public class Formatie
    {
        public Verkiezing GekozenVerkiezing { get; private set; }
        public int ZetelsSelectie { get; private set; }
        public bool KamerMeerderheid { get; private set; }
        public string Premier { get; private set; }

        //Ik geef een verkiezing mee omdat die nooit leeg mag zijn
        public Formatie(Verkiezing gekozenVerkiezing)
        {
            this.GekozenVerkiezing = gekozenVerkiezing;
        }

        //Hier wordt gekeken of de coalitie die meegegeven wordt ook daadwerkelijk een meerderheid heeft of niet
        public void BerekenCoalitie(List<Partij> partijen)
        {
            partijen.OrderBy(p => p.Stemmen);
            ZetelsSelectie = partijen.Sum(p => p.Zetels);
            KamerMeerderheid = ZetelsSelectie >= GekozenVerkiezing.ZetelsMeerderheid;
        }

        //Hier wordt de uitslag berekend van een partij.
        //Het percentage en aantal zetels wordt hier dus berekend aan de hand van het aantal stemmen dat een partij heeft van het totaal
        public void BerekenUitslag(List<Partij> partijen)
        {
            int totaalStemmen = partijen.Sum(p => p.Stemmen);

            foreach (Partij p in partijen)
            {
                if (p.Stemmen != 0)
                {
                    p.SetPercentage(Math.Round(100 / (decimal)totaalStemmen * (decimal)p.Stemmen, 2));
                    p.SetZetels((int)Math.Round(((decimal)p.Stemmen / (decimal)totaalStemmen) * (decimal)GekozenVerkiezing.Zetels));
                }
            }
        }

        //Hier wordt een lijst zo geordered dat de partij met de meeste stemmen op plek 0 in de lijst komt te staan
        public void BepaalPremier(IEnumerable<Partij> partijen)
        {
            Partij partij = partijen.OrderByDescending(p => p.Stemmen).First();
            Premier = partij.Lijsttrekker;
        }
    }
}