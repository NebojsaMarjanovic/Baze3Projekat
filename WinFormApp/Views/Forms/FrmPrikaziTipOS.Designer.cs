namespace WinFormApp.Views.Forms
{
    partial class FrmPrikaziTipOS
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
            this.cbTipOS = new System.Windows.Forms.ComboBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.lblAddupdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPotrvdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip: ";
            // 
            // cbTipOS
            // 
            this.cbTipOS.FormattingEnabled = true;
            this.cbTipOS.Location = new System.Drawing.Point(262, 70);
            this.cbTipOS.Name = "cbTipOS";
            this.cbTipOS.Size = new System.Drawing.Size(199, 33);
            this.cbTipOS.TabIndex = 1;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(214, 166);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(112, 34);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // lblAddupdate
            // 
            this.lblAddupdate.AutoSize = true;
            this.lblAddupdate.Location = new System.Drawing.Point(87, 252);
            this.lblAddupdate.Name = "lblAddupdate";
            this.lblAddupdate.Size = new System.Drawing.Size(255, 25);
            this.lblAddupdate.TabIndex = 3;
            this.lblAddupdate.Text = "Naziv novog/izmenjenog tipa: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(87, 280);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(374, 31);
            this.txtNaziv.TabIndex = 6;
            // 
            // btnPotrvdi
            // 
            this.btnPotrvdi.Location = new System.Drawing.Point(190, 332);
            this.btnPotrvdi.Name = "btnPotrvdi";
            this.btnPotrvdi.Size = new System.Drawing.Size(136, 41);
            this.btnPotrvdi.TabIndex = 7;
            this.btnPotrvdi.Text = "Potvrdi";
            this.btnPotrvdi.UseVisualStyleBackColor = true;
            this.btnPotrvdi.Click += new System.EventHandler(this.btnPotrvdi_Click);
            // 
            // FrmPrikaziTipOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 446);
            this.Controls.Add(this.btnPotrvdi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddupdate);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.cbTipOS);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrikaziTipOS";
            this.Text = "FrmPrikaziTipOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbTipOS;
        private Button btnIzmeni;
        private Label lblAddupdate;
        private Button button1;
        private Button button2;
        private TextBox txtNaziv;
        private Button btnPotrvdi;
    }
}