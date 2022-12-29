namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziOsnovnaSredstva
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOsnvnoSredstvo = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsnvnoSredstvo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsnvnoSredstvo
            // 
            this.dgvOsnvnoSredstvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsnvnoSredstvo.Location = new System.Drawing.Point(92, 62);
            this.dgvOsnvnoSredstvo.Name = "dgvOsnvnoSredstvo";
            this.dgvOsnvnoSredstvo.RowHeadersWidth = 62;
            this.dgvOsnvnoSredstvo.RowTemplate.Height = 33;
            this.dgvOsnvnoSredstvo.Size = new System.Drawing.Size(573, 378);
            this.dgvOsnvnoSredstvo.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(726, 104);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(138, 47);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(726, 393);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(138, 47);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Izmeni ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCPrikaziOsnovnaSredstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvOsnvnoSredstvo);
            this.Name = "UCPrikaziOsnovnaSredstva";
            this.Size = new System.Drawing.Size(925, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsnvnoSredstvo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOsnvnoSredstvo;
        private Button btnDodaj;
        private Button btnObrisi;
        private Button button1;
    }
}
