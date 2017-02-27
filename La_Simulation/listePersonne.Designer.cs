namespace La_Simulation
{
    partial class frmListePersonne
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
            this.cboListePersonne = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboListePersonne
            // 
            this.cboListePersonne.FormattingEnabled = true;
            this.cboListePersonne.Location = new System.Drawing.Point(45, 61);
            this.cboListePersonne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboListePersonne.Name = "cboListePersonne";
            this.cboListePersonne.Size = new System.Drawing.Size(426, 26);
            this.cboListePersonne.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(290, 141);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 32);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Annuler";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(143, 141);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(112, 32);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Supprimer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmListePersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 262);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cboListePersonne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListePersonne";
            this.Text = "listePersonne";
            this.Load += new System.EventHandler(this.listePersonne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboListePersonne;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
    }
}