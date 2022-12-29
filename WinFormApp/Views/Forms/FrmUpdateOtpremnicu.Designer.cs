namespace WinFormApp.Views.Forms
{
    partial class FrmUpdateOtpremnicu
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
            this.cbNacinIsporuke = new System.Windows.Forms.ComboBox();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.cbNarudzbenica = new System.Windows.Forms.ComboBox();
            this.dateDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajOtpremnicu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNacinIsporuke
            // 
            this.cbNacinIsporuke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNacinIsporuke.FormattingEnabled = true;
            this.cbNacinIsporuke.Location = new System.Drawing.Point(424, 337);
            this.cbNacinIsporuke.Name = "cbNacinIsporuke";
            this.cbNacinIsporuke.Size = new System.Drawing.Size(300, 33);
            this.cbNacinIsporuke.TabIndex = 26;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(424, 264);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(300, 33);
            this.cbDobavljac.TabIndex = 25;
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(424, 196);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(300, 33);
            this.cbZaposleni.TabIndex = 24;
            // 
            // cbNarudzbenica
            // 
            this.cbNarudzbenica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNarudzbenica.FormattingEnabled = true;
            this.cbNarudzbenica.Location = new System.Drawing.Point(424, 130);
            this.cbNarudzbenica.Name = "cbNarudzbenica";
            this.cbNarudzbenica.Size = new System.Drawing.Size(300, 33);
            this.cbNarudzbenica.TabIndex = 23;
            // 
            // dateDatumIzdavanja
            // 
            this.dateDatumIzdavanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateDatumIzdavanja.Location = new System.Drawing.Point(424, 65);
            this.dateDatumIzdavanja.Name = "dateDatumIzdavanja";
            this.dateDatumIzdavanja.Size = new System.Drawing.Size(300, 31);
            this.dateDatumIzdavanja.TabIndex = 22;
            // 
            // btnDodajOtpremnicu
            // 
            this.btnDodajOtpremnicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajOtpremnicu.Location = new System.Drawing.Point(266, 444);
            this.btnDodajOtpremnicu.Name = "btnDodajOtpremnicu";
            this.btnDodajOtpremnicu.Size = new System.Drawing.Size(180, 49);
            this.btnDodajOtpremnicu.TabIndex = 20;
            this.btnDodajOtpremnicu.Text = "Izmeni otpremnicu";
            this.btnDodajOtpremnicu.UseVisualStyleBackColor = true;
            this.btnDodajOtpremnicu.Click += new System.EventHandler(this.btnDodajOtpremnicu_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Način isporuke: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dobavljač: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Otpremnicu kreirao: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Na osnovu narudzbenice: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum izdavanja:";
            // 
            // FrmUpdateOtpremnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.cbNacinIsporuke);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.cbNarudzbenica);
            this.Controls.Add(this.dateDatumIzdavanja);
            this.Controls.Add(this.btnDodajOtpremnicu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUpdateOtpremnicu";
            this.Text = "FrmUpdateOtpremnicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbNacinIsporuke;
        private ComboBox cbDobavljac;
        private ComboBox cbZaposleni;
        private ComboBox cbNarudzbenica;
        private DateTimePicker dateDatumIzdavanja;
        private Button btnDodajOtpremnicu;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
    }
}