namespace WinFormApp.Views.Forms
{
    partial class FrmUpdateRacun
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
            this.btnIzmeniRacun = new System.Windows.Forms.Button();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.cbNarudzbenica = new System.Windows.Forms.ComboBox();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.dateDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.txtBrojRata = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeniRacun
            // 
            this.btnIzmeniRacun.Location = new System.Drawing.Point(373, 664);
            this.btnIzmeniRacun.Name = "btnIzmeniRacun";
            this.btnIzmeniRacun.Size = new System.Drawing.Size(172, 53);
            this.btnIzmeniRacun.TabIndex = 35;
            this.btnIzmeniRacun.Text = "Izmeni račun";
            this.btnIzmeniRacun.UseVisualStyleBackColor = true;
            this.btnIzmeniRacun.Click += new System.EventHandler(this.btnIzmeniRacun_Click);
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(489, 236);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(321, 33);
            this.cbDobavljac.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Dobavljač";
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(489, 586);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(321, 33);
            this.cbZaposleni.TabIndex = 32;
            // 
            // cbNarudzbenica
            // 
            this.cbNarudzbenica.FormattingEnabled = true;
            this.cbNarudzbenica.Location = new System.Drawing.Point(489, 520);
            this.cbNarudzbenica.Name = "cbNarudzbenica";
            this.cbNarudzbenica.Size = new System.Drawing.Size(321, 33);
            this.cbNarudzbenica.TabIndex = 31;
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Location = new System.Drawing.Point(489, 323);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(321, 154);
            this.rtbNapomena.TabIndex = 30;
            this.rtbNapomena.Text = "";
            // 
            // dateDatumIzdavanja
            // 
            this.dateDatumIzdavanja.Location = new System.Drawing.Point(489, 164);
            this.dateDatumIzdavanja.Name = "dateDatumIzdavanja";
            this.dateDatumIzdavanja.Size = new System.Drawing.Size(321, 31);
            this.dateDatumIzdavanja.TabIndex = 29;
            // 
            // txtBrojRata
            // 
            this.txtBrojRata.Location = new System.Drawing.Point(489, 98);
            this.txtBrojRata.Name = "txtBrojRata";
            this.txtBrojRata.Size = new System.Drawing.Size(321, 31);
            this.txtBrojRata.TabIndex = 28;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(489, 39);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(321, 31);
            this.txtIznos.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Račun dodao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Na osnovu narudžbenice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Napomena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Datum izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Broj rata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Iznos:";
            // 
            // FrmUpdateRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 768);
            this.Controls.Add(this.btnIzmeniRacun);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.cbNarudzbenica);
            this.Controls.Add(this.rtbNapomena);
            this.Controls.Add(this.dateDatumIzdavanja);
            this.Controls.Add(this.txtBrojRata);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUpdateRacun";
            this.Text = "FrmUpdateRacun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIzmeniRacun;
        private ComboBox cbDobavljac;
        private Label label8;
        private ComboBox cbZaposleni;
        private ComboBox cbNarudzbenica;
        private RichTextBox rtbNapomena;
        private DateTimePicker dateDatumIzdavanja;
        private TextBox txtBrojRata;
        private TextBox txtIznos;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}