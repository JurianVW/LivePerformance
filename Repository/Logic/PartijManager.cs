using System.Collections.Generic;
using Models;
using Repository.Database;

namespace Repository.Logic
{
    public class PartijManager
    {
        private IVerkiezingsContext context;

        public PartijManager(IVerkiezingsContext verkiezingContext)
        {
            this.context = verkiezingContext;
        }

        public void SavePartij(Partij partij)
        {
            context.SavePartij(partij);
        }

        public void DeletePartij(Partij partij)
        {
            context.DeletePartij(partij);
        }

        public List<Partij> GetAllPartij()
        {
            return context.GetAllPartij();
        }
    }
}