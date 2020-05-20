using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieMedicamente;
using StocareData;

namespace InterfataFarmacie
{
    
    public partial class FormMedicament : Form
    {
        IStocareData adminMedicamente;
        List<string> VarsteSelectate = new List<string>();
        public FormMedicament()
        {
            InitializeComponent();
            adminMedicamente = StocareFactory.GetAdministratorStocare();
            Numenume.medicamentes = adminMedicamente.GetMedicamente();
        }
        
        

        // On use the button adds the input into the list and the file.
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            
            ErrorCode codValidare = Validare(txtNume.Text, txtPret.Text);
            if (codValidare != ErrorCode.CORRECT)
            {
                MarcheazaIncorect(codValidare);
            }
            else
            {
               
                Medicamente m = new Medicamente(txtNume.Text, Convert.ToSingle(txtPret.Text));
                if (rdbRetetaDa.Checked == true)
                    m.Reteta = rdbRetetaDa.Text;
                else
                    m.Reteta = rdbRetetaNu.Text;
                m.Administrare = cbnAdministrare.Text;
                m.Varsta = new List<string>();
                m.Varsta.AddRange(VarsteSelectate);


                adminMedicamente.AddMedicament(m);
                lblMesaj.Visible = true;
                lblMesaj.Text = "Medicamentul a fost adaugat";
                
                ResetControale();
                
            }
            Numenume.medicamentes = adminMedicamente.GetMedicamente();
        }
        // Checks if pret is an integer from 0-9 in ASCII code 
        private bool VerificarePret(string pret)
        {
            int index = 0;
            foreach(char c in pret)
            {
                if (c == 46)
                {
                    if (pret.IndexOf(c) == 0 || index != 0)
                        return false;
                    else
                        index++;
                }
                    if ((c < 46 && c != 47) || c > 57)
                        return false;
                
            }
            return true;
        }
        //Resets the controls after using any button.
        private void ResetControale()
        {
            txtNume.Text = txtPret.Text = string.Empty;
            lblMesaj.Text = default;
            lblID.Text = string.Empty;
            cbnAdministrare.Text = string.Empty;
            rdbRetetaDa.Checked = false;
            rdbRetetaNu.Checked = false;
            ckb12ani.Checked = false;
            ckb18ani.Checked = false;
            ckb36luni.Checked = false;
            ckb3luni.Checked = false;

        }
        // Validates if the fields are completed.
        private ErrorCode Validare(string nume, string pret)
        {
            ErrorCode rezultatValidare = ErrorCode.CORRECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= ErrorCode.NUME_INCORECT;
            }
            if (pret == string.Empty || VerificarePret(pret)== false)
            {
                rezultatValidare |= ErrorCode.PRET_INCORECT;
            }
            if (rdbRetetaNu.Checked == false && rdbRetetaDa.Checked==false)
            {
                rezultatValidare |= ErrorCode.RETETA_INCORECTA;
            }
            if (cbnAdministrare.Text == string.Empty)
            {
                rezultatValidare |= ErrorCode.ADMINISTRARE_INCORECTA;
            }
            if (ValidareCheckBox()== false)
            {
                rezultatValidare |= ErrorCode.VARSTA_INCORECTA;
            }
            return rezultatValidare;
        }
        // Resets the color of the labels after they are marked with red.
        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = default;
            lblPret.ForeColor = default;
            lblReteta.ForeColor = default;
            lblTipMed.ForeColor = default;
            lblVarsta.ForeColor = default;

        }
        // Marks with red the labels of the fields which are incorrect.
        private void MarcheazaIncorect(ErrorCode codValidare)
        {
            
            if ((codValidare & ErrorCode.NUME_INCORECT) == ErrorCode.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            else
                lblNume.ForeColor = default;
            if ((codValidare & ErrorCode.PRET_INCORECT) == ErrorCode.PRET_INCORECT)
            {
                lblPret.ForeColor = Color.Red;
            }
            else
                lblPret.ForeColor = default;
            if ((codValidare & ErrorCode.RETETA_INCORECTA) == ErrorCode.RETETA_INCORECTA)
            {
                lblReteta.ForeColor = Color.Red;
            }
            else
                lblReteta.ForeColor = default;
            if ((codValidare & ErrorCode.ADMINISTRARE_INCORECTA) == ErrorCode.ADMINISTRARE_INCORECTA)
            {
                lblTipMed.ForeColor = Color.Red;
            }
            else
                lblTipMed.ForeColor = default;
            if ((codValidare & ErrorCode.VARSTA_INCORECTA) == ErrorCode.VARSTA_INCORECTA)
            {
                lblVarsta.ForeColor = Color.Red;
            }
            else
                lblVarsta.ForeColor = default;
        }
        //  On click the button will fill up the List with items from the file where they are saved ( Medicamente.txt)
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            //var antetTabel = string.Format("{0,-5}{1,-35}{2,20}{3,30}\n", "ID", "Nume Medicament", "Pret", "Administrare");
            string ID = "ID", nume = "Nume Medicament", pret = "Pret", administrare = "Administrare";
            var antetTabel = ID.PadRight(5 - ID.Length) + nume.PadRight(20 - nume.Length) + "\t\t" + pret.PadRight(7 - pret.Length) + "\t\t" + administrare.PadRight(15-administrare.Length)+"\t"+"Reteta";
            
            lstAfisare.Items.Add(antetTabel);
            List<Medicamente> medicamente = adminMedicamente.GetMedicamente();
            foreach (Medicamente m in medicamente)
            {
                if (m.Administrare == "Supozitoare")
                {
                    var linieTabel = m.IdMedicament.ToString().PadRight(5 - m.IdMedicament.ToString().Length) + m.Nume.PadRight(20 - m.Nume.Length) + "\t\t\t" + m.Pret.ToString().PadRight(7 - m.Pret.ToString().Length) + "\t\t" + m.Administrare.PadRight(15 - m.Administrare.Length) + "\t" + m.Reteta;
                    //var linieTabel = string.Format("{0,-5}{1,-35}{2,20}{3,30}", m.IdMedicament, m.Nume, m.Pret, m.Administrare);
                    lstAfisare.Items.Add(linieTabel);
                }
                else
                {
                    var linieTabel = m.IdMedicament.ToString().PadRight(5 - m.IdMedicament.ToString().Length) + m.Nume.PadRight(20 - m.Nume.Length) + "\t\t\t" + m.Pret.ToString().PadRight(7 - m.Pret.ToString().Length) + "\t\t" + m.Administrare.PadRight(15 - m.Administrare.Length) + "\t\t" + m.Reteta;
                    //var linieTabel = string.Format("{0,-5}{1,-35}{2,20}{3,30}", m.IdMedicament, m.Nume, m.Pret, m.Administrare);
                    lstAfisare.Items.Add(linieTabel);
                }
                Numenume.medicamentes = adminMedicamente.GetMedicamente();
            }
        }
        // Input name and search for it in the list , followed by displaying a text with the price of the drug , its name and type.
        private void btnCauta_Click(object sender, EventArgs e)
        {
            Numenume.medicamentes = adminMedicamente.GetMedicamente();
            Medicamente m = adminMedicamente.GetMedicament(txtNume.Text);
            if (m != null)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = m.ConvertString();
            }
            else
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Medicamentul nu a fost gasit !";
            }
        }
        
        // After selecting an item from the List you rewrite and edit the data. Use the Edit button to apply the changes.
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            
            if (lstAfisare.SelectedIndex >= 0)
            {
                Numenume.medicamentes = adminMedicamente.GetMedicamente();
                Formtest Editeaza = new Formtest(lstAfisare.SelectedIndex-1);
                Editeaza.ShowDialog();
                adminMedicamente.UpdateMedicament(Editeaza.ReturnData());


            }
            //ResetCuloareEtichete();
            //ErrorCode codValidare = Validare(txtNume.Text, txtPret.Text);
            //if(codValidare !=ErrorCode.CORRECT)
            //{
            //    MarcheazaIncorect(codValidare);
            //}
            //else
            //{
                

            //    if (lstAfisare.SelectedIndex >= 0)
            //    {
            //        Medicamente m = new Medicamente(txtNume.Text,Convert.ToSingle(txtPret.Text));

            //        m.IdMedicament = Int32.Parse(lblID.Text);
            //        if (rdbRetetaDa.Checked == true)
            //            m.Reteta = rdbRetetaDa.Text;
            //        else
            //            m.Reteta = rdbRetetaNu.Text;
            //        m.Administrare = cbnAdministrare.Text;
            //        m.Varsta = new List<string>();
            //        m.Varsta.AddRange(VarsteSelectate);

            //        adminMedicamente.UpdateMedicament(m);
            //        lblMesaj.Visible = true;
            //        lblMesaj.Text = "Medicamentul a fost editat";
            //        ResetControale();
            //    }
            //}
        }
        // Select an index from the List and fills the text boxes with the information from that selected index
        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetControale();
            Medicamente m = adminMedicamente.GetMedicamentByIndex(lstAfisare.SelectedIndex-1);

            if (m != null)
            {
                lblID.Text = m.IdMedicament.ToString();
                txtNume.Text = m.Nume;
                txtPret.Text = m.Pret.ToString();
                cbnAdministrare.Text = m.Administrare;
                if (m.Reteta == "Da")
                    rdbRetetaDa.Checked = true;
                else
                    rdbRetetaNu.Checked = true;

                foreach(var vrst in gpbVarsta.Controls)
                {
                    if(vrst is CheckBox)
                    {
                        var vrstBox = vrst as CheckBox;
                        foreach (String vst in m.Varsta)
                            if (vrstBox.Text==vst)
                                vrstBox.Checked = true;
                    }
                }
            }
                
        }
        // Checkbox Varsta validare 
        private bool ValidareCheckBox()
        {
            foreach(var ckb in gpbVarsta.Controls)
            {
                if(ckb is CheckBox)
                {
                    var vrst = ckb as CheckBox;
                    if (vrst.Checked == true)
                        VarsteSelectate.Add(vrst.Text);
                    else
                        VarsteSelectate.Remove(vrst.Text);
                }
            }
            if (VarsteSelectate.Count != 0)
                return true;
            else
                return false;
        }
        
        private void menuActualizare_Click(object sender, EventArgs e)
        {
            if(lstAfisare.SelectedIndex>=0)
            {
                dtActualizare.Value = Numenume.medicamentes[lstAfisare.SelectedIndex - 1].dataActualizare;
            }
        }

        private void menuExpirare_Click(object sender, EventArgs e)
        {
            if(lstAfisare.SelectedIndex>=0)
            {
                dtActualizare.Value = Numenume.medicamentes[lstAfisare.SelectedIndex - 1].dataExpirare;
            }
        }

        private void filtreazaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            FormData afisareData = new FormData();
            afisareData.ShowDialog();

            string ID = "ID", nume = "Nume Medicament", pret = "Pret", administrare = "Administrare";
            var antetTabel = ID.PadRight(5 - ID.Length) + nume.PadRight(20 - nume.Length) + "\t\t" + pret.PadRight(7 - pret.Length) + "\t\t" + administrare.PadRight(15 - administrare.Length) + "\t" + "Reteta";

            lstAfisare.Items.Add(antetTabel);
            
            foreach (var data in Numenume.medicamentes)
            {

                ///Daca dataActualizare adica aia din medicament e mai devreme decat data selectata(mai mica) -> numar negativ
                ///Daca dataPanaLa e mai devreme decat dataActualizare din medicament atunci returneaza numar negativ
                if (DateTime.Compare(afisareData.dataDeLa, data.dataActualizare) <= 0 && DateTime.Compare(afisareData.dataPanaLa, data.dataActualizare) >= 0)
                {   
                    if (data.Administrare == "Supozitoare")
                    {
                        var linieTabel = data.IdMedicament.ToString().PadRight(5 - data.IdMedicament.ToString().Length) + data.Nume.PadRight(20 - data.Nume.Length) + "\t\t\t" + data.Pret.ToString().PadRight(7 - data.Pret.ToString().Length) + "\t\t" + data.Administrare.PadRight(15 - data.Administrare.Length) + "\t" + data.Reteta;
                        lstAfisare.Items.Add(linieTabel);
                    }
                    else
                    {
                        var linieTabel = data.IdMedicament.ToString().PadRight(5 - data.IdMedicament.ToString().Length) + data.Nume.PadRight(20 - data.Nume.Length) + "\t\t\t" + data.Pret.ToString().PadRight(7 - data.Pret.ToString().Length) + "\t\t" + data.Administrare.PadRight(15 - data.Administrare.Length) + "\t\t" + data.Reteta;
                        lstAfisare.Items.Add(linieTabel);
                    }
                }
            }

            
        }
    }
    public static class Numenume
    {
        public static List<Medicamente> medicamentes = new List<Medicamente>();

    }
}

