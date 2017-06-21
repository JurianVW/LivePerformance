using System.Collections.Generic;
using Models;

namespace Repository.Database
{
    public class VerkiezingLocalContext : IVerkiezingsContext
    {
        public void SavePartij(Partij partij)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePartij(Partij partij)
        {
            throw new System.NotImplementedException();
        }

        public List<Partij> GetAllPartij()
        {
            throw new System.NotImplementedException();
        }

        public void SaveVerkiezing(Verkiezing verkiezing)
        {
            throw new System.NotImplementedException();
        }

        public void AddPartijVerkiezing(int verkiezingID, int partijID)
        {
            throw new System.NotImplementedException();
        }

        public List<Verkiezing> GetAllVerkiezingen()
        {
            throw new System.NotImplementedException();
        }

        public void GetVerkiezingPartijen(Verkiezing verkiezing)
        {
            throw new System.NotImplementedException();
        }

        public void GetVerkiezingUitslagen(Verkiezing verkiezing)
        {
            throw new System.NotImplementedException();
        }

        public void SaveUitslag(Uitslag uitslag, int verkiezingID)
        {
            throw new System.NotImplementedException();
        }

        public void GetUitslagPartijen(Uitslag uitslag)
        {
            throw new System.NotImplementedException();
        }
    }
}