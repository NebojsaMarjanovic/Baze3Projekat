namespace WinFormApp.Views.Forms
{
    partial class FrmAddOsnovnoSredstvo
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtJM = new System.Windows.Forms.TextBox();
            this.cbTipOS = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv osnovnog sredstva: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jedinica mere: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip osnovnog sredstva:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(441, 69);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(279, 31);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtJM
            // 
            this.txtJM.Location = new System.Drawing.Point(441, 124);
            this.txtJM.Name = "txtJM";
            this.txtJM.Size = new System.Drawing.Size(279, 31);
            this.txtJM.TabIndex = 4;
            // 
            // cbTipOS
            // 
            this.cbTipOS.FormattingEnabled = true;
            this.cbTipOS.Location = new System.Drawing.Point(441, 191);
            this.cbTipOS.Name = "cbTipOS";
            this.cbTipOS.Size = new System.Drawing.Size(279, 33);
            this.cbTipOS.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj osnovno sredstvo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddOsnovnoSredstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTipOS);
            this.Controls.Add(this.txtJM);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddOsnovnoSredstvo";
            this.Text = "FrmAddOsnovnoSredstvo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNaziv;
        private TextBox txtJM;
        private ComboBox cbTipOS;
        private Button button1;
    }
}