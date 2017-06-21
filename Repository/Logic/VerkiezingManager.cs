using Models;
using Repository.Database;
using System.Collections.Generic;

namespace Repository.Logic
{
    public class VerkiezingManager
    {
        private IVerkiezingsContext context;

        public VerkiezingManager(IVerkiezingsContext verkiezingContext)
        {
            this.context = verkiezingContext;
        }

        public void SaveVerkiezing(Verkiezing verkiezing)
        {
            context.SaveVerkiezing(verkiezing);
        }

        public void AddPartijVerkiezing(int verkiezingID, int partijID)
        {
            context.AddPartijVerkiezing(verkiezingID, partijID);
        }

        public List<Verkiezing> GetAllVerkiezingen()
        {
            return context.GetAllVerkiezingen();
        }

        public void GetVerkiezingPartijen(Verkiezing verkiezing)
        {
            context.GetVerkiezingPartijen(verkiezing);
        }

        public void GetVerkiezingsUitslagen(Verkiezing verkiezing)
        {
            context.GetVerkiezingUitslagen(verkiezing);
        }
    }
}