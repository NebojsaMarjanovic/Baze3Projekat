namespace WinFormApp.Views.Forms
{
    partial class FrmUpdateStavkaRacuna
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cbOsnovnoSredstvo = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.Location = new System.Drawing.Point(446, 588);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(187, 54);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cbOsnovnoSredstvo
            // 
            this.cbOsnovnoSredstvo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOsnovnoSredstvo.FormattingEnabled = true;
            this.cbOsnovnoSredstvo.Location = new System.Drawing.Point(599, 154);
            this.cbOsnovnoSredstvo.Name = "cbOsnovnoSredstvo";
            this.cbOsnovnoSredstvo.Size = new System.Drawing.Size(321, 33);
            this.cbOsnovnoSredstvo.TabIndex = 12;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicina.Location = new System.Drawing.Point(599, 434);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(321, 31);
            this.txtKolicina.TabIndex = 11;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(599, 293);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(321, 31);
            this.txtCena.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Osnovno sredstvo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolicina";
            // 
            // FrmUpdateStavkaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 796);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cbOsnovnoSredstvo);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateStavkaRacuna";
            this.Text = "FrmUpdateStavkaRacuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIzmeni;
        private ComboBox cbOsnovnoSredstvo;
        private TextBox txtKolicina;
        private TextBox txtCena;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}