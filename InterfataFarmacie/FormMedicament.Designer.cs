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
            this.lblVarsta = new System.Windows.Forms.Label();
            this.gpbVarsta = new System.Windows.Forms.GroupBox();
            this.ckb3luni = new System.Windows.Forms.CheckBox();
            this.ckb12ani = new System.Windows.Forms.CheckBox();
            this.ckb18ani = new System.Windows.Forms.CheckBox();
            this.ckb36luni = new System.Windows.Forms.CheckBox();
            this.gpbReteta.SuspendLayout();
            this.gpbVarsta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 19);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(60, 24);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.lblPret.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(12, 56);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(46, 24);
            this.lblPret.TabIndex = 1;
            this.lblPret.Text = "Pret";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(129, 24);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(139, 20);
            this.txtNume.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(129, 61);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(139, 20);
            this.txtPret.TabIndex = 3;
            // 
            // lblReteta
            // 
            this.lblReteta.AutoSize = true;
            this.lblReteta.BackColor = System.Drawing.Color.Transparent;
            this.lblReteta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReteta.Location = new System.Drawing.Point(12, 112);
            this.lblReteta.Name = "lblReteta";
            this.lblReteta.Size = new System.Drawing.Size(63, 24);
            this.lblReteta.TabIndex = 4;
            this.lblReteta.Text = "Reteta";
            // 
            // lblTipMed
            // 
            this.lblTipMed.AutoSize = true;
            this.lblTipMed.BackColor = System.Drawing.Color.Transparent;
            this.lblTipMed.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipMed.Location = new System.Drawing.Point(12, 160);
            this.lblTipMed.Name = "lblTipMed";
            this.lblTipMed.Size = new System.Drawing.Size(112, 21);
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
            this.cbnAdministrare.Location = new System.Drawing.Point(129, 163);
            this.cbnAdministrare.Name = "cbnAdministrare";
            this.cbnAdministrare.Size = new System.Drawing.Size(139, 21);
            this.cbnAdministrare.TabIndex = 8;
            // 
            // lstAfisare
            // 
            this.lstAfisare.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(274, 24);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(502, 329);
            this.lstAfisare.TabIndex = 9;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Transparent;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(16, 284);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(97, 41);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseaza.Location = new System.Drawing.Point(171, 284);
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
            this.btnEditeaza.Location = new System.Drawing.Point(16, 331);
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
            this.btnCauta.Location = new System.Drawing.Point(171, 331);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(97, 41);
            this.btnCauta.TabIndex = 13;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // gpbReteta
            // 
            this.gpbReteta.BackColor = System.Drawing.Color.Transparent;
            this.gpbReteta.Controls.Add(this.rdbRetetaNu);
            this.gpbReteta.Controls.Add(this.rdbRetetaDa);
            this.gpbReteta.Location = new System.Drawing.Point(129, 87);
            this.gpbReteta.Name = "gpbReteta";
            this.gpbReteta.Size = new System.Drawing.Size(139, 64);
            this.gpbReteta.TabIndex = 14;
            this.gpbReteta.TabStop = false;
            // 
            // rdbRetetaNu
            // 
            this.rdbRetetaNu.AutoSize = true;
            this.rdbRetetaNu.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRetetaNu.Location = new System.Drawing.Point(79, 23);
            this.rdbRetetaNu.Name = "rdbRetetaNu";
            this.rdbRetetaNu.Size = new System.Drawing.Size(54, 28);
            this.rdbRetetaNu.TabIndex = 1;
            this.rdbRetetaNu.TabStop = true;
            this.rdbRetetaNu.Text = "Nu";
            this.rdbRetetaNu.UseVisualStyleBackColor = true;
            // 
            // rdbRetetaDa
            // 
            this.rdbRetetaDa.AutoSize = true;
            this.rdbRetetaDa.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRetetaDa.Location = new System.Drawing.Point(6, 23);
            this.rdbRetetaDa.Name = "rdbRetetaDa";
            this.rdbRetetaDa.Size = new System.Drawing.Size(53, 28);
            this.rdbRetetaDa.TabIndex = 0;
            this.rdbRetetaDa.TabStop = true;
            this.rdbRetetaDa.Text = "Da";
            this.rdbRetetaDa.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(12, 400);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(87, 24);
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
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.BackColor = System.Drawing.Color.Transparent;
            this.lblVarsta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarsta.Location = new System.Drawing.Point(12, 184);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(65, 24);
            this.lblVarsta.TabIndex = 17;
            this.lblVarsta.Text = "Varsta";
            // 
            // gpbVarsta
            // 
            this.gpbVarsta.BackColor = System.Drawing.Color.Transparent;
            this.gpbVarsta.Controls.Add(this.ckb3luni);
            this.gpbVarsta.Controls.Add(this.ckb12ani);
            this.gpbVarsta.Controls.Add(this.ckb18ani);
            this.gpbVarsta.Controls.Add(this.ckb36luni);
            this.gpbVarsta.Location = new System.Drawing.Point(16, 206);
            this.gpbVarsta.Name = "gpbVarsta";
            this.gpbVarsta.Size = new System.Drawing.Size(252, 72);
            this.gpbVarsta.TabIndex = 18;
            this.gpbVarsta.TabStop = false;
            // 
            // ckb3luni
            // 
            this.ckb3luni.AutoSize = true;
            this.ckb3luni.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb3luni.Location = new System.Drawing.Point(145, 12);
            this.ckb3luni.Name = "ckb3luni";
            this.ckb3luni.Size = new System.Drawing.Size(86, 25);
            this.ckb3luni.TabIndex = 22;
            this.ckb3luni.Text = "< 3 luni";
            this.ckb3luni.UseVisualStyleBackColor = true;
            // 
            // ckb12ani
            // 
            this.ckb12ani.AutoSize = true;
            this.ckb12ani.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb12ani.Location = new System.Drawing.Point(30, 43);
            this.ckb12ani.Name = "ckb12ani";
            this.ckb12ani.Size = new System.Drawing.Size(83, 25);
            this.ckb12ani.TabIndex = 21;
            this.ckb12ani.Text = ">12 ani";
            this.ckb12ani.UseVisualStyleBackColor = true;
            // 
            // ckb18ani
            // 
            this.ckb18ani.AutoSize = true;
            this.ckb18ani.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb18ani.Location = new System.Drawing.Point(145, 43);
            this.ckb18ani.Name = "ckb18ani";
            this.ckb18ani.Size = new System.Drawing.Size(83, 25);
            this.ckb18ani.TabIndex = 20;
            this.ckb18ani.Text = ">18 ani";
            this.ckb18ani.UseVisualStyleBackColor = true;
            // 
            // ckb36luni
            // 
            this.ckb36luni.AutoSize = true;
            this.ckb36luni.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb36luni.Location = new System.Drawing.Point(30, 12);
            this.ckb36luni.Name = "ckb36luni";
            this.ckb36luni.Size = new System.Drawing.Size(90, 25);
            this.ckb36luni.TabIndex = 19;
            this.ckb36luni.Text = "3-6 luni";
            this.ckb36luni.UseVisualStyleBackColor = true;
            this.ckb36luni.CheckedChanged += new System.EventHandler(this.ckbVarstaSLCT_Changed);
            // 
            // FormMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataFarmacie.Properties.Resources.shutterstock_1452259085_cutii_medicamente_fiole_antibiotice2_1035x425;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.lblVarsta);
            this.Controls.Add(this.gpbVarsta);
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
            this.MaximumSize = new System.Drawing.Size(840, 500);
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "FormMedicament";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gpbReteta.ResumeLayout(false);
            this.gpbReteta.PerformLayout();
            this.gpbVarsta.ResumeLayout(false);
            this.gpbVarsta.PerformLayout();
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
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.GroupBox gpbVarsta;
        private System.Windows.Forms.CheckBox ckb3luni;
        private System.Windows.Forms.CheckBox ckb12ani;
        private System.Windows.Forms.CheckBox ckb18ani;
        private System.Windows.Forms.CheckBox ckb36luni;
    }
}

