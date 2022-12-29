namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziOtpremnice
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
            this.dgvOtpremnice = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOtpremnice
            // 
            this.dgvOtpremnice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpremnice.Location = new System.Drawing.Point(126, 56);
            this.dgvOtpremnice.Name = "dgvOtpremnice";
            this.dgvOtpremnice.RowHeadersWidth = 62;
            this.dgvOtpremnice.RowTemplate.Height = 33;
            this.dgvOtpremnice.Size = new System.Drawing.Size(1018, 315);
            this.dgvOtpremnice.TabIndex = 0;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.Location = new System.Drawing.Point(715, 407);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(200, 51);
            this.btnIzmeni.TabIndex = 39;
            this.btnIzmeni.Text = "Izmeni otpremnicu";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(944, 407);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(200, 51);
            this.btnObrisi.TabIndex = 40;
            this.btnObrisi.Text = "Obriši otpremnicu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(479, 407);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 51);
            this.btnDodaj.TabIndex = 41;
            this.btnDodaj.Text = "Dodaj otpremnicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // UCPrikaziOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvOtpremnice);
            this.Name = "UCPrikaziOtpremnice";
            this.Size = new System.Drawing.Size(1260, 752);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvOtpremnice;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnDodaj;
    }
}
