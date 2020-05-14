using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieMedicamente;

namespace StocareData
{
    public interface IStocareData
    {
        void AddMedicament(Medicamente m);
        List<Medicamente> GetMedicamente();
        Medicamente GetMedicament(string nume);
        bool UpdateMedicament(Medicamente m);
        Medicamente GetMedicamentByIndex(int index);

    }
}
