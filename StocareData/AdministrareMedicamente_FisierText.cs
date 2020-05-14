using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibrarieMedicamente;

namespace StocareData
{
    public class AdministrareMedicamente_FisierText : IStocareData
    {
        private const int ID_PRIMUL_MEDICAMENT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }

        public AdministrareMedicamente_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public void AddMedicament(Medicamente m)
        {
            m.IdMedicament = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(m.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Medicamente> GetMedicamente()
        {
            List<Medicamente> medicamente = new List<Medicamente>();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
  
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicamente m = new Medicamente(line);
                        medicamente.Add(m);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return medicamente;
        }

        public Medicamente GetMedicament(string nume)
        {
            try
            {
                using (StreamReader sr= new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line=sr.ReadLine()) != null)
                    {
                        Medicamente medicament = new Medicamente(line);
                        if (medicament.Nume.Equals(nume))
                            return medicament;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        private int GetId()
        {
            int IdMedicament = ID_PRIMUL_MEDICAMENT;
            try
            {
                using(StreamReader sr= new StreamReader(NumeFisier))
                {
                    string line;
                    while((line= sr.ReadLine()) != null)
                    {
                        Medicamente m = new Medicamente(line);
                        IdMedicament = m.IdMedicament + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return IdMedicament;
        }

        public bool UpdateMedicament(Medicamente medicamentActualizat)
        {
            List<Medicamente> medicamente = GetMedicamente();
            bool actualizareCuSucces = false;
            try
            {
                using(StreamWriter swFisierText= new StreamWriter(NumeFisier,false))
                {
                    foreach(Medicamente med in medicamente)
                    {
                        if(med.IdMedicament != medicamentActualizat.IdMedicament)
                        {
                            swFisierText.WriteLine(med.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(medicamentActualizat.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        public Medicamente GetMedicamentByIndex(int index)
        {
            try
            {
                
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    int contor = 0;
                   
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicamente medicament = new Medicamente(line);
                        if (contor == index)
                            return medicament;
                        contor++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
    }
}
