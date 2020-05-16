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


namespace InterfataFarmacie
{
    public partial class FormEdit : Form
    {
        List<string> VarsteSelectate = new List<string>();
        Medicamente med = new Medicamente();
        
        public FormEdit()
        {
            InitializeComponent();
        }
        public FormEdit(Medicamente m)
        {
            med= m;
            
            rtbEditNume.Text = med.Nume;
            rtbEditPret.Text = Convert.ToString(m.Pret);
            cmbAdministrare.Text = m.Administrare;
            if (m.Reteta == "Da")
                rdbEditDa.Checked = true;
            else
                rdbEditNu.Checked = true;
            foreach (var vrst in gpbVarstaEdit.Controls)
            {
                if (vrst is CheckBox)
                {
                    var vrstBox = vrst as CheckBox;
                    foreach (String vst in m.Varsta)
                        if (vrstBox.Text == vst)
                            vrstBox.Checked = true;
                }
            }
        }

        private void btnFinishEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MarcheazaIncorect(ErrorCode codValidare)
        {

            if ((codValidare & ErrorCode.NUME_INCORECT) == ErrorCode.NUME_INCORECT)
            {
                lblEditNume.ForeColor = Color.Red;
            }
            else
                lblEditNume.ForeColor = default;
            if ((codValidare & ErrorCode.PRET_INCORECT) == ErrorCode.PRET_INCORECT)
            {
                lblEditPret.ForeColor = Color.Red;
            }
            else
                lblEditPret.ForeColor = default;
            if ((codValidare & ErrorCode.RETETA_INCORECTA) == ErrorCode.RETETA_INCORECTA)
            {
                lblEditReteta.ForeColor = Color.Red;
            }
            else
                lblEditReteta.ForeColor = default;
            if ((codValidare & ErrorCode.ADMINISTRARE_INCORECTA) == ErrorCode.ADMINISTRARE_INCORECTA)
            {
                lblEditAdministrare.ForeColor = Color.Red;
            }
            else
                lblEditAdministrare.ForeColor = default;
            if ((codValidare & ErrorCode.VARSTA_INCORECTA) == ErrorCode.VARSTA_INCORECTA)
            {
                lblEditVarsta.ForeColor = Color.Red;
            }
            else
                lblEditVarsta.ForeColor = default;
        }

        private void ResetCuloareEtichete()
        {
            lblEditAdministrare.ForeColor = default;
            lblEditNume.ForeColor = default;
            lblEditPret.ForeColor = default;
            lblEditReteta.ForeColor = default;
            lblEditVarsta.ForeColor = default;

        }

        private bool VerificarePret(string pret)
        {
            int index = 0;
            foreach (char c in pret)
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
        private ErrorCode Validare(string nume, string pret)
        {
            ErrorCode rezultatValidare = ErrorCode.CORRECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= ErrorCode.NUME_INCORECT;
            }
            if (pret == string.Empty || VerificarePret(pret) == false)
            {
                rezultatValidare |= ErrorCode.PRET_INCORECT;
            }
            if (rdbEditDa.Checked == false && rdbEditNu.Checked == false)
            {
                rezultatValidare |= ErrorCode.RETETA_INCORECTA;
            }
            if (cmbAdministrare.Text == string.Empty)
            {
                rezultatValidare |= ErrorCode.ADMINISTRARE_INCORECTA;
            }
            if (VarsteSelectate.Count != 0)
            {
                rezultatValidare |= ErrorCode.VARSTA_INCORECTA;
            }
            return rezultatValidare;
        }

        private void ckbVarstaChanged(object sender, EventArgs e)
        {
            CheckBox checkChanged = sender as CheckBox;

            string varstaSelectata = checkChanged.Text;

            if (checkChanged.Checked == true)
                VarsteSelectate.Add(varstaSelectata);
            else
                VarsteSelectate.Remove(varstaSelectata);
        }
    }
}
