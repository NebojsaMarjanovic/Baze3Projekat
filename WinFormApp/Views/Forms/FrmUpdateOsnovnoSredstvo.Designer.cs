namespace WinFormApp.Views.Forms
{
    partial class FrmUpdateOsnovnoSredstvo
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
            this.cbTipOS = new System.Windows.Forms.ComboBox();
            this.txtJM = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(281, 363);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(224, 54);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Izmeni osnovno sredstvo";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cbTipOS
            // 
            this.cbTipOS.FormattingEnabled = true;
            this.cbTipOS.Location = new System.Drawing.Point(455, 256);
            this.cbTipOS.Name = "cbTipOS";
            this.cbTipOS.Size = new System.Drawing.Size(279, 33);
            this.cbTipOS.TabIndex = 12;
            // 
            // txtJM
            // 
            this.txtJM.Location = new System.Drawing.Point(455, 189);
            this.txtJM.Name = "txtJM";
            this.txtJM.Size = new System.Drawing.Size(279, 31);
            this.txtJM.TabIndex = 11;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(455, 134);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(279, 31);
            this.txtNaziv.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tip osnovnog sredstva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jedinica mere: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv osnovnog sredstva: ";
            // 
            // FrmUpdateOsnovnoSredstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 594);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cbTipOS);
            this.Controls.Add(this.txtJM);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateOsnovnoSredstvo";
            this.Text = "FrmUpdateOsnovnoSredstvo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIzmeni;
        private ComboBox cbTipOS;
        private TextBox txtJM;
        private TextBox txtNaziv;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}