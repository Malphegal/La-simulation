﻿namespace La_Simulation
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombrePersonne = new System.Windows.Forms.Label();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnListerToutLeMonde = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimerPersonne = new System.Windows.Forms.Button();
            this.btnAjouterPlanete = new System.Windows.Forms.Button();
            this.lblNombrePlanete = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnListerToutesLesPlanetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombrePersonne
            // 
            this.lblNombrePersonne.AutoSize = true;
            this.lblNombrePersonne.Location = new System.Drawing.Point(496, 151);
            this.lblNombrePersonne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePersonne.Name = "lblNombrePersonne";
            this.lblNombrePersonne.Size = new System.Drawing.Size(176, 18);
            this.lblNombrePersonne.TabIndex = 0;
            this.lblNombrePersonne.Tag = "0";
            this.lblNombrePersonne.Text = "Nombre de personnes : 0";
            // 
            // btnAjouterPersonne
            // 
            this.btnAjouterPersonne.Location = new System.Drawing.Point(483, 186);
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Size = new System.Drawing.Size(201, 36);
            this.btnAjouterPersonne.TabIndex = 0;
            this.btnAjouterPersonne.Text = "Ajouter une personne...";
            this.btnAjouterPersonne.UseVisualStyleBackColor = true;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.btnAjouterPersonne_Click);
            // 
            // btnListerToutLeMonde
            // 
            this.btnListerToutLeMonde.Location = new System.Drawing.Point(483, 267);
            this.btnListerToutLeMonde.Name = "btnListerToutLeMonde";
            this.btnListerToutLeMonde.Size = new System.Drawing.Size(131, 48);
            this.btnListerToutLeMonde.TabIndex = 2;
            this.btnListerToutLeMonde.Text = "Lister toutes les Personnes...";
            this.btnListerToutLeMonde.UseVisualStyleBackColor = true;
            this.btnListerToutLeMonde.Click += new System.EventHandler(this.btnListerToutLeMonde_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(540, 438);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(163, 35);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter l\'application...";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimerPersonne
            // 
            this.btnSupprimerPersonne.Location = new System.Drawing.Point(483, 225);
            this.btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            this.btnSupprimerPersonne.Size = new System.Drawing.Size(200, 36);
            this.btnSupprimerPersonne.TabIndex = 1;
            this.btnSupprimerPersonne.Text = "Supprimer une personne...";
            this.btnSupprimerPersonne.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonne.Click += new System.EventHandler(this.btnSupprimerPersonne_Click);
            // 
            // btnAjouterPlanete
            // 
            this.btnAjouterPlanete.Location = new System.Drawing.Point(35, 186);
            this.btnAjouterPlanete.Name = "btnAjouterPlanete";
            this.btnAjouterPlanete.Size = new System.Drawing.Size(200, 36);
            this.btnAjouterPlanete.TabIndex = 4;
            this.btnAjouterPlanete.Text = "Ajouter une planète...";
            this.btnAjouterPlanete.UseVisualStyleBackColor = true;
            this.btnAjouterPlanete.Click += new System.EventHandler(this.btnAjouterPlanete_Click);
            // 
            // lblNombrePlanete
            // 
            this.lblNombrePlanete.AutoSize = true;
            this.lblNombrePlanete.Location = new System.Drawing.Point(52, 151);
            this.lblNombrePlanete.Name = "lblNombrePlanete";
            this.lblNombrePlanete.Size = new System.Drawing.Size(161, 18);
            this.lblNombrePlanete.TabIndex = 5;
            this.lblNombrePlanete.Text = "Nombre de planètes : 0";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(187, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(369, 58);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "            La simulation :\r\nProjet jeu sous Windows Form";
            // 
            // btnListerToutesLesPlanetes
            // 
            this.btnListerToutesLesPlanetes.Location = new System.Drawing.Point(35, 267);
            this.btnListerToutesLesPlanetes.Name = "btnListerToutesLesPlanetes";
            this.btnListerToutesLesPlanetes.Size = new System.Drawing.Size(131, 48);
            this.btnListerToutesLesPlanetes.TabIndex = 2;
            this.btnListerToutesLesPlanetes.Text = "Lister toutes les Planètes...";
            this.btnListerToutesLesPlanetes.UseVisualStyleBackColor = true;
            this.btnListerToutesLesPlanetes.Click += new System.EventHandler(this.btnListerToutesLesPlanetes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 485);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblNombrePlanete);
            this.Controls.Add(this.btnAjouterPlanete);
            this.Controls.Add(this.btnSupprimerPersonne);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnListerToutesLesPlanetes);
            this.Controls.Add(this.btnListerToutLeMonde);
            this.Controls.Add(this.btnAjouterPersonne);
            this.Controls.Add(this.lblNombrePersonne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "La simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePersonne;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Button btnListerToutLeMonde;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimerPersonne;
        private System.Windows.Forms.Button btnAjouterPlanete;
        private System.Windows.Forms.Label lblNombrePlanete;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnListerToutesLesPlanetes;
    }
}

