using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataFarmacie
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        public DateTime dataDeLa { get; set; }
        public DateTime dataPanaLa { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            dataDeLa = dateDeLa.Value;
            dataPanaLa = datePanaLa.Value;

            this.Hide();
        }
    }
}
