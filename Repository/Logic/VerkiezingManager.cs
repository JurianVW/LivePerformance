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

        public List<Verkiezing> GetAllVerkiezingen()
        {
            return context.GetAllVerkiezingen();
        }

        public Verkiezing GetVerkiezing(int verkiezingID)
        {
            return GetVerkiezing(verkiezingID);
        }
    }
}