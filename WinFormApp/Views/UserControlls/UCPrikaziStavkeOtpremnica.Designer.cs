namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziStavkeOtpremnica
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
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiStavku.Location = new System.Drawing.Point(828, 418);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(160, 51);
            this.btnObrisiStavku.TabIndex = 48;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniStavku.Location = new System.Drawing.Point(828, 301);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(160, 51);
            this.btnIzmeniStavku.TabIndex = 47;
            this.btnIzmeniStavku.Text = "Izmeni stavku";
            this.btnIzmeniStavku.UseVisualStyleBackColor = true;
            this.btnIzmeniStavku.Click += new System.EventHandler(this.btnIzmeniStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStavku.Location = new System.Drawing.Point(828, 186);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(160, 51);
            this.btnDodajStavku.TabIndex = 46;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(56, 186);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 62;
            this.dgvStavke.RowTemplate.Height = 33;
            this.dgvStavke.Size = new System.Drawing.Size(725, 283);
            this.dgvStavke.TabIndex = 45;
            // 
            // UCPrikaziStavkeOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnIzmeniStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvStavke);
            this.Name = "UCPrikaziStavkeOtpremnica";
            this.Size = new System.Drawing.Size(1045, 655);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnObrisiStavku;
        private Button btnIzmeniStavku;
        private Button btnDodajStavku;
        private DataGridView dgvStavke;
    }
}
