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

        public void SaveUitslag(Uitslag uitslag, int verkiezingID)
        {
            context.SaveUitslag(uitslag, verkiezingID);
        }

        public void GetUitslagPartijen(Uitslag uitslag)
        {
            context.GetUitslagPartijen(uitslag);
        }
    }
}