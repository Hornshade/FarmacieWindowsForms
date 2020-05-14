using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieMedicamente;

namespace StocareData
{
    public class AdministrareMedicamente_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMedicamente_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMedicament(Medicamente m)
        {
            throw new Exception("Optiunea AddMedicament nu este implementata");
        }

        public List<Medicamente> GetMedicamente()
        {
            throw new Exception("Optiunea GetMedicamente nu este implementata");
        }

        public Medicamente GetMedicament(string nume)
        {
            throw new Exception("Optiunea GetMedicament nu este implementata");
        }

        public bool UpdateMedicament(Medicamente m)
        {
            throw new Exception("Optiunea UpdateMedicament nu este implementata");
        }
        public Medicamente GetMedicamentByIndex(int index)
        {
            throw new Exception("Optiunea GetMedicamentByIndex nu este implementata");
        }

    }
}
