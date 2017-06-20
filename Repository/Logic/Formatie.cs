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
        private Verkiezing gekozenVerkiezing;

        private int TotaalAantalStemmen;

        public Formatie(IVerkiezingsContext verkiezingContext)
        {
            this.context = verkiezingContext;
        }

        public void BerekenPartijGegevens(List<Partij> partijen)
        {
            throw new NotImplementedException();
        }

        public bool CheckCoalitieMeerderheid(List<Partij> partijen)
        {
            throw new NotImplementedException();
        }

        public List<Partij> GetPartijOverzicht(Uitslag uitslag)
        {
            throw new NotImplementedException();
        }

        public string BepaalPremier(List<Partij> partijen)
        {
            throw new NotImplementedException();
        }

        public void ExportCoalitie(List<Partij> partijen, string locatie, string afzender, string ontvanger)
        {
            throw new NotImplementedException();
        }

        public void SaveCoalitie(Coalitie coalitie)
        {
            context.SaveCoalitie(coalitie);
        }
    }
}