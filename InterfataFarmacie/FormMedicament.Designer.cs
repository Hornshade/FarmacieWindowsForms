namespace InterfataFarmacie
{
    partial class FormMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblReteta = new System.Windows.Forms.Label();
            this.lblTipMed = new System.Windows.Forms.Label();
            this.cbnAdministrare = new System.Windows.Forms.ComboBox();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.gpbReteta = new System.Windows.Forms.GroupBox();
            this.rdbRetetaNu = new System.Windows.Forms.RadioButton();
            this.rdbRetetaDa = new System.Windows.Forms.RadioButton();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbReteta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 22);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(12, 59);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(38, 20);
            this.lblPret.TabIndex = 1;
            this.lblPret.Text = "Pret";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(111, 24);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(139, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(111, 61);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(139, 20);
            this.txtPret.TabIndex = 3;
            // 
            // lblReteta
            // 
            this.lblReteta.AutoSize = true;
            this.lblReteta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReteta.Location = new System.Drawing.Point(12, 114);
            this.lblReteta.Name = "lblReteta";
            this.lblReteta.Size = new System.Drawing.Size(58, 20);
            this.lblReteta.TabIndex = 4;
            this.lblReteta.Text = "Reteta";
            // 
            // lblTipMed
            // 
            this.lblTipMed.AutoSize = true;
            this.lblTipMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipMed.Location = new System.Drawing.Point(7, 161);
            this.lblTipMed.Name = "lblTipMed";
            this.lblTipMed.Size = new System.Drawing.Size(98, 20);
            this.lblTipMed.TabIndex = 7;
            this.lblTipMed.Text = "Administrare";
            // 
            // cbnAdministrare
            // 
            this.cbnAdministrare.FormattingEnabled = true;
            this.cbnAdministrare.Items.AddRange(new object[] {
            "Supozitoare",
            "Injectabil",
            "Sirop",
            "Pastile"});
            this.cbnAdministrare.Location = new System.Drawing.Point(111, 163);
            this.cbnAdministrare.Name = "cbnAdministrare";
            this.cbnAdministrare.Size = new System.Drawing.Size(139, 21);
            this.cbnAdministrare.TabIndex = 8;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(271, 10);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(502, 329);
            this.lstAfisare.TabIndex = 9;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(15, 243);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(97, 41);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.Location = new System.Drawing.Point(134, 243);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(97, 41);
            this.btnAfiseaza.TabIndex = 11;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditeaza.Location = new System.Drawing.Point(15, 290);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(97, 41);
            this.btnEditeaza.TabIndex = 12;
            this.btnEditeaza.Text = "Editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(134, 290);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(97, 41);
            this.btnCauta.TabIndex = 13;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // gpbReteta
            // 
            this.gpbReteta.Controls.Add(this.rdbRetetaNu);
            this.gpbReteta.Controls.Add(this.rdbRetetaDa);
            this.gpbReteta.Location = new System.Drawing.Point(111, 87);
            this.gpbReteta.Name = "gpbReteta";
            this.gpbReteta.Size = new System.Drawing.Size(139, 64);
            this.gpbReteta.TabIndex = 14;
            this.gpbReteta.TabStop = false;
            // 
            // rdbRetetaNu
            // 
            this.rdbRetetaNu.AutoSize = true;
            this.rdbRetetaNu.Location = new System.Drawing.Point(52, 41);
            this.rdbRetetaNu.Name = "rdbRetetaNu";
            this.rdbRetetaNu.Size = new System.Drawing.Size(39, 17);
            this.rdbRetetaNu.TabIndex = 1;
            this.rdbRetetaNu.TabStop = true;
            this.rdbRetetaNu.Text = "Nu";
            this.rdbRetetaNu.UseVisualStyleBackColor = true;
            // 
            // rdbRetetaDa
            // 
            this.rdbRetetaDa.AutoSize = true;
            this.rdbRetetaDa.Location = new System.Drawing.Point(52, 11);
            this.rdbRetetaDa.Name = "rdbRetetaDa";
            this.rdbRetetaDa.Size = new System.Drawing.Size(39, 17);
            this.rdbRetetaDa.TabIndex = 0;
            this.rdbRetetaDa.TabStop = true;
            this.rdbRetetaDa.Text = "Da";
            this.rdbRetetaDa.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(10, 388);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(100, 25);
            this.lblMesaj.TabIndex = 15;
            this.lblMesaj.Text = "lblMesaj";
            this.lblMesaj.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Visible = false;
            // 
            // FormMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.gpbReteta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.cbnAdministrare);
            this.Controls.Add(this.lblTipMed);
            this.Controls.Add(this.lblReteta);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblNume);
            this.Name = "FormMedicament";
            this.gpbReteta.ResumeLayout(false);
            this.gpbReteta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblReteta;
        private System.Windows.Forms.Label lblTipMed;
        private System.Windows.Forms.ComboBox cbnAdministrare;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.GroupBox gpbReteta;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton rdbRetetaNu;
        private System.Windows.Forms.RadioButton rdbRetetaDa;
    }
}

