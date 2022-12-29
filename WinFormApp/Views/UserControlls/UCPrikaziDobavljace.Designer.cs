namespace WinFormApp.Views.UserControlls
{
    partial class UCPrikaziDobavljace
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
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Location = new System.Drawing.Point(98, 26);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.RowHeadersWidth = 62;
            this.dgvDobavljaci.RowTemplate.Height = 33;
            this.dgvDobavljaci.Size = new System.Drawing.Size(513, 282);
            this.dgvDobavljaci.TabIndex = 0;
            // 
            // PrikaziDobavljace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDobavljaci);
            this.Name = "PrikaziDobavljace";
            this.Size = new System.Drawing.Size(724, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDobavljaci;
    }
}
