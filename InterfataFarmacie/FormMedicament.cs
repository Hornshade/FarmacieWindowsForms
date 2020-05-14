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
        public FormMedicament()
        {
            InitializeComponent();
            adminMedicamente = StocareFactory.GetAdministratorStocare();
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
                Medicamente m = new Medicamente(txtNume.Text, Int32.Parse(txtPret.Text));
                if (rdbRetetaDa.Checked == true)
                    m.Reteta = rdbRetetaDa.Text;
                else
                    m.Reteta = rdbRetetaNu.Text;
                m.Administrare = cbnAdministrare.Text;


                adminMedicamente.AddMedicament(m);
                lblMesaj.Visible = true;
                lblMesaj.Text = "Medicamentul a fost adaugat";

                ResetControale();
                
            }
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

        }
        // Validates if the fields are completed.
        private ErrorCode Validare(string nume, string pret)
        {
            ErrorCode rezultatValidare = ErrorCode.CORRECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= ErrorCode.NUME_INCORECT;
            }
            if (pret == string.Empty)
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
            return rezultatValidare;
        }
        // Resets the color of the labels after they are marked with red.
        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = default;
            lblPret.ForeColor = default;
            lblReteta.ForeColor = default;
            lblTipMed.ForeColor = default;

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
        }
        
        //  On click the button will fill up the List with items from the file where they are saved ( Medicamente.txt)
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            lstAfisare.Items.Clear();
            //var antetTabel = string.Format("{0,-5}{1,-35}{2,20}{3,30}\n", "ID", "Nume Medicament", "Pret", "Administrare");
            string ID = "ID", nume = "Nume Medicament", pret = "Pret", administrare = "Administrare";
            var antetTabel = ID.PadRight(5 - ID.Length) + nume.PadRight(20 - nume.Length) + "\t\t" + pret.PadRight(7 - pret.Length) + "\t\t" + administrare.PadRight(15-administrare.Length)+"\t\t"+"Reteta";
            
            lstAfisare.Items.Add(antetTabel);
            List<Medicamente> medicamente = adminMedicamente.GetMedicamente();
            foreach(Medicamente m in medicamente)
            {
                var linieTabel = m.IdMedicament.ToString().PadRight(5 - m.IdMedicament.ToString().Length) + m.Nume.PadRight(20 - m.Nume.Length) + "\t\t\t" + m.Pret.ToString().PadRight(7 - m.Pret.ToString().Length) + "\t\t" + m.Administrare.PadRight(15-m.Administrare.Length)+"\t\t\t"+m.Reteta;
                //var linieTabel = string.Format("{0,-5}{1,-35}{2,20}{3,30}", m.IdMedicament, m.Nume, m.Pret, m.Administrare);
                lstAfisare.Items.Add(linieTabel);
            }
        }
        // Input name and search for it in the list , followed by displaying a text with the price of the drug , its name and type.
        private void btnCauta_Click(object sender, EventArgs e)
        {
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
            ResetCuloareEtichete();
            ErrorCode codValidare = Validare(txtNume.Text, txtPret.Text);
            if(codValidare !=ErrorCode.CORRECT)
            {
                MarcheazaIncorect(codValidare);
            }
            else
            {

                if (lstAfisare.SelectedIndex >= 0)
                {
                    Medicamente m = new Medicamente(txtNume.Text,Int32.Parse(txtPret.Text));

                    m.IdMedicament = Int32.Parse(lblID.Text);
                    if (rdbRetetaDa.Checked == true)
                        m.Reteta = rdbRetetaDa.Text;
                    else
                        m.Reteta = rdbRetetaNu.Text;
                    m.Administrare = cbnAdministrare.Text;

                    adminMedicamente.UpdateMedicament(m);
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "Medicamentul a fost editat";
                    ResetControale();
                }
            }
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
            }
                
        }
    }
}
