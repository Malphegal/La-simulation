using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using La_Simulation.Classes;
using System.Data.OleDb;

namespace La_Simulation
{
    public partial class frmPrincipal : Form
    {
            // Variables globales

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\BaseDeDonnée\bdLaSimulation.mdb");

            // Constructeurs

        public frmPrincipal() // Constructeur
        {
            InitializeComponent();
        }

            // --------------------------
            // Méthodes évenementielles
            // --------------------------

        private void Form1_Load(object sender, EventArgs e) // Charge la classe Personne de toutes les Personnes
        {
                // Initialiser la variable static listPersonne

            using (var cmd = new OleDbCommand("SELECT * FROM Personne", connec))
            {
                connec.Open();

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) // On ajoute toutes les Personnes de la base dans le tableau static de Personne
                    Personne.ajouterUnePersonne(dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), byte.Parse(dr.GetValue(4).ToString()));

                connec.Close();

                    // Changer le texte du label lblNombrePersonne

                cmd.CommandText = "SELECT count(*) FROM Personne";
                connec.Open();

                lblNombrePersonne.Tag = (int)cmd.ExecuteScalar();
                lblNombrePersonne.Text = "Nombre de personnes : " + lblNombrePersonne.Tag.ToString();
            }
        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e) // Ajouter une Personne dans la base de donnée
        {
            if (new frmAjouterEntite("Personne").ShowDialog() == DialogResult.OK)
            {
                    lblNombrePersonne.Tag = int.Parse(lblNombrePersonne.Tag.ToString()) + 1; // Faire une fonction de mise à jour
                    lblNombrePersonne.Text = "Nombre de personnes : " + lblNombrePersonne.Tag.ToString(); // Faire une fonction de mise à jour
            }
            GC.Collect();
        } // /!\ Mise à jour à faire

        private void btnListerToutLeMonde_Click(object sender, EventArgs e) // Liste toutes les Personnes dans des MessageBox.Show
        {
            foreach(string p in Personne.listerPersonnes())
                MessageBox.Show(p);
        }

        private void btnListerToutesLesPlanetes_Click(object sender, EventArgs e) // Liste toutes les Planètes dans des MessageBox.Show
        {
            foreach (string p in Planete.listerPlanetes())
                MessageBox.Show(p);
        }

        private void btnQuitter_Click(object sender, EventArgs e) // Quitte l'application
        {
            Application.Exit();
        }

        private void btnSupprimerPersonne_Click(object sender, EventArgs e) // Supprimer une Personne de la base de donnée
        {
                // A VOIR POUR LES USING /!\
            using (var frm = new frmListePersonne())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (var cmd = new OleDbCommand("DELETE FROM Personne WHERE id = " + frmListePersonne.idASupprimer, connec)) // ATTENTION 'OR 1 = 1'
                    {
                        connec.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader()) { }
                        Personne.nextIdMoinsUn(); // Retirer 1 à la valeur nextId de Personne
                    }

                    using (var cmd = new OleDbCommand("UPDATE Personne SET id = id - 1 WHERE id > " + frmListePersonne.idASupprimer, connec)) // ATTENTION 'OR 1 = 1'
                    {
                        connec.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader()) { }

                        lblNombrePersonne.Tag = int.Parse(lblNombrePersonne.Tag.ToString()) - 1; // Faire une fonction de mise à jour
                        lblNombrePersonne.Text = "Nombre de personnes : " + lblNombrePersonne.Tag.ToString(); // Faire une fonction de mise à jour
                    }
                }
            }
            GC.Collect();
        } // /!\ Mise à jour à faire

        private void btnAjouterPlanete_Click(object sender, EventArgs e) // Ajouter une Planete dans la base de donnée
        {
            if (new frmAjouterEntite("Planète").ShowDialog() == DialogResult.OK)
            {
                lblNombrePlanete.Tag = int.Parse(lblNombrePlanete.Tag.ToString()) + 1; // Faire une fonction de mise à jour
                lblNombrePlanete.Text = "Nombre de planètes : " + lblNombrePlanete.Tag.ToString(); // Faire une fonction de mise à jour
            }
            GC.Collect();
        } // /!\ Mise à jour à faire
    }
}
