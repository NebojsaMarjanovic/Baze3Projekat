namespace WinFormApp.Views.Forms
{
    partial class FrmAddOtpremnica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajOtpremnicu = new System.Windows.Forms.Button();
            this.txtBrOtpremnice = new System.Windows.Forms.TextBox();
            this.dateDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.cbNarudzbenica = new System.Windows.Forms.ComboBox();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.cbNacinIsporuke = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj otpremnice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Na osnovu narudzbenice: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Način isporuke: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dobavljač: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Otpremnicu kreirao: ";
            // 
            // btnDodajOtpremnicu
            // 
            this.btnDodajOtpremnicu.Location = new System.Drawing.Point(288, 517);
            this.btnDodajOtpremnicu.Name = "btnDodajOtpremnicu";
            this.btnDodajOtpremnicu.Size = new System.Drawing.Size(180, 49);
            this.btnDodajOtpremnicu.TabIndex = 7;
            this.btnDodajOtpremnicu.Text = "Dodaj otpremnicu";
            this.btnDodajOtpremnicu.UseVisualStyleBackColor = true;
            this.btnDodajOtpremnicu.Click += new System.EventHandler(this.btnDodajOtpremnicu_Click);
            // 
            // txtBrOtpremnice
            // 
            this.txtBrOtpremnice.Location = new System.Drawing.Point(445, 73);
            this.txtBrOtpremnice.Name = "txtBrOtpremnice";
            this.txtBrOtpremnice.Size = new System.Drawing.Size(300, 31);
            this.txtBrOtpremnice.TabIndex = 8;
            // 
            // dateDatumIzdavanja
            // 
            this.dateDatumIzdavanja.Location = new System.Drawing.Point(445, 144);
            this.dateDatumIzdavanja.Name = "dateDatumIzdavanja";
            this.dateDatumIzdavanja.Size = new System.Drawing.Size(300, 31);
            this.dateDatumIzdavanja.TabIndex = 9;
            // 
            // cbNarudzbenica
            // 
            this.cbNarudzbenica.FormattingEnabled = true;
            this.cbNarudzbenica.Location = new System.Drawing.Point(445, 209);
            this.cbNarudzbenica.Name = "cbNarudzbenica";
            this.cbNarudzbenica.Size = new System.Drawing.Size(300, 33);
            this.cbNarudzbenica.TabIndex = 10;
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(445, 275);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(300, 33);
            this.cbZaposleni.TabIndex = 11;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(445, 343);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(300, 33);
            this.cbDobavljac.TabIndex = 12;
            // 
            // cbNacinIsporuke
            // 
            this.cbNacinIsporuke.FormattingEnabled = true;
            this.cbNacinIsporuke.Location = new System.Drawing.Point(445, 416);
            this.cbNacinIsporuke.Name = "cbNacinIsporuke";
            this.cbNacinIsporuke.Size = new System.Drawing.Size(300, 33);
            this.cbNacinIsporuke.TabIndex = 13;
            // 
            // FrmAddOtpremnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 630);
            this.Controls.Add(this.cbNacinIsporuke);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.cbNarudzbenica);
            this.Controls.Add(this.dateDatumIzdavanja);
            this.Controls.Add(this.txtBrOtpremnice);
            this.Controls.Add(this.btnDodajOtpremnicu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddOtpremnicu";
            this.Text = "FrmDodajOtpremnicu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDodajOtpremnicu;
        private TextBox txtBrOtpremnice;
        private DateTimePicker dateDatumIzdavanja;
        private ComboBox cbNarudzbenica;
        private ComboBox cbZaposleni;
        private ComboBox cbDobavljac;
        private ComboBox cbNacinIsporuke;
    }
}