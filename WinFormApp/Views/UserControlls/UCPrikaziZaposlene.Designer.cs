namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziZaposlene
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
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumZaposlenja = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Location = new System.Drawing.Point(275, 81);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowHeadersWidth = 62;
            this.dgvZaposleni.RowTemplate.Height = 33;
            this.dgvZaposleni.Size = new System.Drawing.Size(720, 308);
            this.dgvZaposleni.TabIndex = 0;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetalji.Location = new System.Drawing.Point(528, 462);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(148, 50);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum zaposlenja";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj telefona";
            // 
            // txtDatumZaposlenja
            // 
            this.txtDatumZaposlenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumZaposlenja.Location = new System.Drawing.Point(693, 651);
            this.txtDatumZaposlenja.Name = "txtDatumZaposlenja";
            this.txtDatumZaposlenja.Size = new System.Drawing.Size(302, 31);
            this.txtDatumZaposlenja.TabIndex = 4;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojTelefona.Location = new System.Drawing.Point(693, 711);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(302, 31);
            this.txtBrojTelefona.TabIndex = 5;
            // 
            // UCPrikaziZaposlene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtDatumZaposlenja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvZaposleni);
            this.Name = "UCPrikaziZaposlene";
            this.Size = new System.Drawing.Size(1267, 941);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvZaposleni;
        private Button btnDetalji;
        private Label label1;
        private Label label2;
        private TextBox txtDatumZaposlenja;
        private TextBox txtBrojTelefona;
    }
}
