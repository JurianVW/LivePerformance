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

        List<Verkiezing> GetAllVerkiezingen();

        Verkiezing GetVerkiezing(int verkiezingID);

        void SaveUitslag(Uitslag uitslag);

        Uitslag GetUitslag(Verkiezing verkiezing);

        void SaveCoalitie(Coalitie coalitie);
    }
}