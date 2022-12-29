namespace WinFormApp.Views.Forms
{
    partial class FrmUpdateStavkaOtpremnice
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
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.dateDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.cbOsnovnoSredstvo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStavku.Location = new System.Drawing.Point(264, 380);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(198, 51);
            this.btnDodajStavku.TabIndex = 17;
            this.btnDodajStavku.Text = "Izmeni stavku ";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicina.Location = new System.Drawing.Point(419, 84);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(295, 31);
            this.txtKolicina.TabIndex = 16;
            // 
            // dateDatumIzdavanja
            // 
            this.dateDatumIzdavanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateDatumIzdavanja.Location = new System.Drawing.Point(419, 166);
            this.dateDatumIzdavanja.Name = "dateDatumIzdavanja";
            this.dateDatumIzdavanja.Size = new System.Drawing.Size(295, 31);
            this.dateDatumIzdavanja.TabIndex = 15;
            // 
            // cbOsnovnoSredstvo
            // 
            this.cbOsnovnoSredstvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOsnovnoSredstvo.FormattingEnabled = true;
            this.cbOsnovnoSredstvo.Location = new System.Drawing.Point(419, 248);
            this.cbOsnovnoSredstvo.Name = "cbOsnovnoSredstvo";
            this.cbOsnovnoSredstvo.Size = new System.Drawing.Size(295, 33);
            this.cbOsnovnoSredstvo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Osnovno sredstvo: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum izdavanja: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Količina:";
            // 
            // FrmUpdateStavkaOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 530);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.dateDatumIzdavanja);
            this.Controls.Add(this.cbOsnovnoSredstvo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUpdateStavkaOtpremnice";
            this.Text = "FrmUpdateStavkaOtpremnice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDodajStavku;
        private TextBox txtKolicina;
        private DateTimePicker dateDatumIzdavanja;
        private ComboBox cbOsnovnoSredstvo;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}