namespace WinFormApp.Views.Forms
{
    partial class FrmAddStavkaRacuna
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
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cbOsnovnoSredstvo = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolicina";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osnovno sredstvo";
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(527, 220);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(321, 31);
            this.txtCena.TabIndex = 3;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicina.Location = new System.Drawing.Point(527, 361);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(321, 31);
            this.txtKolicina.TabIndex = 4;
            // 
            // cbOsnovnoSredstvo
            // 
            this.cbOsnovnoSredstvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOsnovnoSredstvo.FormattingEnabled = true;
            this.cbOsnovnoSredstvo.Location = new System.Drawing.Point(527, 81);
            this.cbOsnovnoSredstvo.Name = "cbOsnovnoSredstvo";
            this.cbOsnovnoSredstvo.Size = new System.Drawing.Size(321, 33);
            this.cbOsnovnoSredstvo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(374, 515);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(187, 54);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FrmAddStavkaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbOsnovnoSredstvo);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddStavkaRacuna";
            this.Text = "FrmAddStavkaRacuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCena;
        private TextBox txtKolicina;
        private ComboBox cbOsnovnoSredstvo;
        private Button btnDodaj;
    }
}