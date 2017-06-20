using Models;
using Repository.Database;

namespace Repository.Logic
{
    public class UitslagManager
    {
        private IVerkiezingsContext context;

        public UitslagManager(IVerkiezingsContext verkiezingContext)
        {
            this.context = verkiezingContext;
        }

        public void SaveUitslag(Uitslag uitslag)
        {
            context.SaveUitslag(uitslag);
        }

        public Uitslag GetUitslag(Verkiezing verkiezing)
        {
            return context.GetUitslag(verkiezing);
        }
    }
}