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
    public partial class Formtest : Form
    {
        
        List<string> VarsteSelectate = new List<string>();
        Medicamente med = new Medicamente();
        int indexz;
        public Formtest(int index)
        {
            indexz = index;
            InitializeComponent();
            AutoCompleteEdit();
        }

        public void AutoCompleteEdit()
        {

            rtbEditNume.Text = Numenume.medicamentes[indexz].Nume;
            rtbEditPret.Text = Convert.ToString(Numenume.medicamentes[indexz].Pret);
            cmbAdministrare.Text = Numenume.medicamentes[indexz].Administrare;
            if (Numenume.medicamentes[indexz].Reteta == "Da") 
                rdbEditDa.Checked = true;
            else
                rdbEditNu.Checked = true;
            
            foreach (var vrst in gpbVarstaEdit.Controls)    //parcurge fiecare checkbox din groupBoxul cu varsta pentru a completa checkboxurile si a transmite informatii din FormMedicament
            {
                if (vrst is CheckBox)
                {
                    var vrstBox = vrst as CheckBox;
                    foreach (String vst in Numenume.medicamentes[indexz].Varsta)
                        if (vrstBox.Text == vst)
                            vrstBox.Checked = true;
                }
            }
            
        }
        
        private void btnFinishEdit_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            ErrorCode codValidare = Validare(rtbEditNume.Text, rtbEditPret.Text);
            if (codValidare != ErrorCode.CORRECT)
            {
                MarcheazaIncorect(codValidare);
            }
            else
            {
                if (indexz >= 0)
                {
                    Medicamente m = new Medicamente(rtbEditNume.Text, Convert.ToSingle(rtbEditPret.Text));
                    

                    m.IdMedicament = indexz+1;
                    if (rdbEditDa.Checked == true)
                        m.Reteta = rdbEditDa.Text;
                    else
                        m.Reteta = rdbEditNu.Text;
                    m.Administrare = cmbAdministrare.Text;
                    m.Varsta = new List<string>();
                    m.Varsta.AddRange(VarsteSelectate);
                    med = m;
                    this.Hide();
                }
            }
            
        }
        public Medicamente ReturnData()
        {
            return med;
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

        }   //poate fi eliminata de aici

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
            if (ValidareCheckBox()== false)
            {
                rezultatValidare |= ErrorCode.VARSTA_INCORECTA;
            }
            return rezultatValidare;
        }
        private bool ValidareCheckBox()
        {
            foreach (var ckb in gpbVarstaEdit.Controls)
            {
                if (ckb is CheckBox)
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
    }
}
