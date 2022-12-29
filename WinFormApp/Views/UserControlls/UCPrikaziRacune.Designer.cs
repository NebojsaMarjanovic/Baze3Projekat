namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziRacune
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRata = new System.Windows.Forms.TextBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.lbl2022 = new System.Windows.Forms.Label();
            this.lbl2021 = new System.Windows.Forms.Label();
            this.lbl2020 = new System.Windows.Forms.Label();
            this.lblPre2020 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.btnIzmeniRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(244, 14);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 62;
            this.dgvRacuni.RowTemplate.Height = 33;
            this.dgvRacuni.Size = new System.Drawing.Size(824, 283);
            this.dgvRacuni.TabIndex = 0;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(244, 365);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(160, 51);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(298, 576);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 62;
            this.dgvStavke.RowTemplate.Height = 33;
            this.dgvStavke.Size = new System.Drawing.Size(725, 283);
            this.dgvStavke.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iznos jedne rate";
            // 
            // txtRata
            // 
            this.txtRata.Location = new System.Drawing.Point(687, 510);
            this.txtRata.Name = "txtRata";
            this.txtRata.Size = new System.Drawing.Size(309, 31);
            this.txtRata.TabIndex = 4;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(1070, 576);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(160, 51);
            this.btnDodajStavku.TabIndex = 5;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // lbl2022
            // 
            this.lbl2022.AutoSize = true;
            this.lbl2022.Location = new System.Drawing.Point(1597, 272);
            this.lbl2022.Name = "lbl2022";
            this.lbl2022.Size = new System.Drawing.Size(0, 25);
            this.lbl2022.TabIndex = 34;
            // 
            // lbl2021
            // 
            this.lbl2021.AutoSize = true;
            this.lbl2021.Location = new System.Drawing.Point(1597, 204);
            this.lbl2021.Name = "lbl2021";
            this.lbl2021.Size = new System.Drawing.Size(0, 25);
            this.lbl2021.TabIndex = 33;
            // 
            // lbl2020
            // 
            this.lbl2020.AutoSize = true;
            this.lbl2020.Location = new System.Drawing.Point(1597, 132);
            this.lbl2020.Name = "lbl2020";
            this.lbl2020.Size = new System.Drawing.Size(0, 25);
            this.lbl2020.TabIndex = 32;
            // 
            // lblPre2020
            // 
            this.lblPre2020.AutoSize = true;
            this.lblPre2020.Location = new System.Drawing.Point(1597, 68);
            this.lblPre2020.Name = "lblPre2020";
            this.lblPre2020.Size = new System.Drawing.Size(0, 25);
            this.lblPre2020.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1270, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Broj racuna iz 2022. godine: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1270, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Broj racuna iz 2021. godine: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1270, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Broj racuna iz 2020. godine: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1270, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Broj racuna pre 2020. godine: ";
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.Location = new System.Drawing.Point(1070, 691);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(160, 51);
            this.btnIzmeniStavku.TabIndex = 35;
            this.btnIzmeniStavku.Text = "Izmeni stavku";
            this.btnIzmeniStavku.UseVisualStyleBackColor = true;
            this.btnIzmeniStavku.Click += new System.EventHandler(this.btnIzmeniStavku_Click);
            // 
            // btnIzmeniRacun
            // 
            this.btnIzmeniRacun.Location = new System.Drawing.Point(741, 365);
            this.btnIzmeniRacun.Name = "btnIzmeniRacun";
            this.btnIzmeniRacun.Size = new System.Drawing.Size(160, 51);
            this.btnIzmeniRacun.TabIndex = 36;
            this.btnIzmeniRacun.Text = "Izmeni račun";
            this.btnIzmeniRacun.UseVisualStyleBackColor = true;
            this.btnIzmeniRacun.Click += new System.EventHandler(this.btnIzmeniRacun_Click);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Location = new System.Drawing.Point(908, 365);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(160, 51);
            this.btnObrisiRacun.TabIndex = 37;
            this.btnObrisiRacun.Text = "Obriši račun";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.btnObrisiRacun_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(1070, 808);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(160, 51);
            this.btnObrisiStavku.TabIndex = 38;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // UCPrikaziRacune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.btnIzmeniRacun);
            this.Controls.Add(this.btnIzmeniStavku);
            this.Controls.Add(this.lbl2022);
            this.Controls.Add(this.lbl2021);
            this.Controls.Add(this.lbl2020);
            this.Controls.Add(this.lblPre2020);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.txtRata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "UCPrikaziRacune";
            this.Size = new System.Drawing.Size(1695, 934);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvRacuni;
        private Button btnDetalji;
        private DataGridView dgvStavke;
        private Label label1;
        private TextBox txtRata;
        private Button btnDodajStavku;
        private Label lbl2022;
        private Label lbl2021;
        private Label lbl2020;
        private Label lblPre2020;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnIzmeniStavku;
        private Button btnIzmeniRacun;
        private Button btnObrisiRacun;
        private Button btnObrisiStavku;
    }
}
