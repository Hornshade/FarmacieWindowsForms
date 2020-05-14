using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieMedicamente
{
    public class Medicamente
    {
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int ADMINISTRARE = 3;
        private const int PRET = 2;
        private const int RETETA = 4;
       

        public int IdMedicament { get; set; }
        public string Nume { get; set; }
        public int Pret { get; set; }
        public string Reteta { get; set; }
        public string Administrare { get; set; }

        #region Constructori

        //implicit
        public Medicamente()
        {
            Nume = string.Empty;
            Pret = 0;
            //IdMedicament++;
        }
        public Medicamente(string _Name, int _Price)
        {
            Nume = _Name;
            Pret = _Price;
            //IdMedicament++;
        }

        // cu 1 param tip string pt linie din fisier text
        public Medicamente(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdMedicament = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Pret = Convert.ToInt32(dateFisier[PRET]);
            Administrare = dateFisier[ADMINISTRARE];
            Reteta = dateFisier[RETETA];
        }
        #endregion
        public string ConvertString()
        {
            
            string m = string.Format("Medicamentul  {0}  are pretul :   {1} , Administrare:{2} si Reteta:{3}", (Nume ?? " NECUNOSCUT "), Pret, Administrare,Reteta);
            return m;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sPrice = Pret.ToString();
            string m = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                SEPARATOR_PRINCIPAL_FISIER, IdMedicament.ToString(), (Nume ?? " NECUNOSCUT "), sPrice, Administrare,Reteta);

            return m;
        }
    }
}
