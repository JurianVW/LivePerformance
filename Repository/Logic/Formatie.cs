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
        private IVerkiezingsContext context;
        public Verkiezing GekozenVerkiezing { get; private set; }
        public int ZetelsSelectie { get; private set; }
        public bool KamerMeerderheid { get; private set; }
        public string Premier { get; private set; }

        public Formatie(IVerkiezingsContext verkiezingContext, Verkiezing gekozenVerkiezing)
        {
            this.context = verkiezingContext;
            this.GekozenVerkiezing = gekozenVerkiezing;
        }

        public void BerekenCoalitie(List<Partij> partijen)
        {
            partijen.OrderBy(p => p.Stemmen);
            ZetelsSelectie = partijen.Sum(p => p.Zetels);
            KamerMeerderheid = ZetelsSelectie >= GekozenVerkiezing.ZetelsMeerderheid;
        }

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

        public void BepaalPremier(IEnumerable<Partij> partijen)
        {
            Partij partij = partijen.OrderByDescending(p => p.Stemmen).First();
            Premier = partij.Lijsttrekker;
        }

        public void ExportCoalitie(List<Partij> partijen, string locatie, string afzender, string ontvanger)
        {
            throw new NotImplementedException();
        }
    }
}