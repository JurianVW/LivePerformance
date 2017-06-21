using System.Collections.Generic;
using Models;

namespace Repository.Database
{
    public interface IVerkiezingsContext
    {
        void SavePartij(Partij partij);

        void DeletePartij(Partij partij);

        List<Partij> GetAllPartij();

        void SaveVerkiezing(Verkiezing verkiezing);

        void AddPartijVerkiezing(int verkiezingID, int partijID);

        List<Verkiezing> GetAllVerkiezingen();

        void GetVerkiezingPartijen(Verkiezing verkiezing);

        void GetVerkiezingUitslagen(Verkiezing verkiezing);

        void SaveUitslag(Uitslag uitslag, int verkiezingID);

        void GetUitslagPartijen(Uitslag uitslag);
    }
}