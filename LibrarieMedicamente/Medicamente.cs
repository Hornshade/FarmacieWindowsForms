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
        private const int VARSTA = 5;
       

        public int IdMedicament { get; set; }
        public string Nume { get; set; }
        public float Pret { get; set; }
        public string Reteta { get; set; }
        public string Administrare { get; set; }
        public List<string> Varsta { get; set; }
        public string VarstaString
        {
            get
            {
                string VarstaStr = string.Empty;

                foreach (string vrst in Varsta)
                {
                    if (VarstaStr != string.Empty)
                    {
                        VarstaStr += SEPARATOR_PRINCIPAL_FISIER;
                    }
                    VarstaStr += vrst;
                }

                return VarstaStr;
            }
        }

        #region Constructori

        //implicit
        public Medicamente()
        {
            Nume = string.Empty;
            Pret = 0;
            //IdMedicament++;
        }
        public Medicamente(string _Name, float _Price)
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
            Pret = Convert.ToSingle(dateFisier[PRET]);
            Administrare = dateFisier[ADMINISTRARE];
            Reteta = dateFisier[RETETA];
            Varsta = new List<string>();
            Varsta.AddRange(dateFisier[VARSTA].Split(SEPARATOR_SECUNDAR_FISIER));
        }
        #endregion
        public string ConvertString()
        {
            
            string m = string.Format("Medicamentul  {0}  are pretul :   {1} , Administrare:{2}\nReteta: {3},pentru varsta: {4}  ", (Nume ?? " NECUNOSCUT "), Pret, Administrare,Reteta,VarstaString);
            return m;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sPrice = Pret.ToString();
            string m = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER, IdMedicament.ToString(), (Nume ?? " NECUNOSCUT "), sPrice, Administrare,Reteta,VarstaString);

            return m;
        }
    }
}
