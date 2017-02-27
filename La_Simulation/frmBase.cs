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
        public frmPrincipal() // Constructeur
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Charge la classe Personne de toutes les Personnes
        {
                // Initialiser la variable static listPersonne

            OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Anacin\Desktop\La_Simulation\La_Simulation\BaseDeDonnée\bdLaSimulation.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Personne", connec);

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

            connec.Close();
        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e) // Ajouter une Personne dans la base de donnée
        {
            if (new frmAjouterPersonne().ShowDialog() == DialogResult.OK)
            {
                lblNombrePersonne.Tag = int.Parse(lblNombrePersonne.Tag.ToString()) + 1; // Faire une fonction de mise à jour
                lblNombrePersonne.Text = "Nombre de personnes : " + lblNombrePersonne.Tag.ToString(); // Faire une fonction de mise à jour
            }
        } // /!\ Mise à jour à faire

        private void btnListerToutLeMonde_Click(object sender, EventArgs e) // Liste toutes les Personnes dans des MessageBox.Show
        {
            OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Anacin\Desktop\La_Simulation\La_Simulation\BaseDeDonnée\bdLaSimulation.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Personne", connec);

            connec.Open();

            OleDbDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
                MessageBox.Show("[" + dr.GetValue(0).ToString() + "] " + dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString() +
                    "(" + dr.GetValue(3).ToString() + ") " + dr.GetValue(4).ToString());

            connec.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e) // Quitte l'application
        {
            Application.Exit();
        }

        private void btnSupprimerPersonne_Click(object sender, EventArgs e) // Supprimer une Personne de la base de donnée
        {
            if (new frmListePersonne().ShowDialog() == DialogResult.OK)
            {
                OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Anacin\Desktop\La_Simulation\La_Simulation\BaseDeDonnée\bdLaSimulation.mdb");
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Personne WHERE id = " + frmListePersonne.idASupprimer, connec);

                connec.Open();

                OleDbDataReader dr = cmd.ExecuteReader();

                connec.Close();

                connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Anacin\Desktop\La_Simulation\La_Simulation\BaseDeDonnée\bdLaSimulation.mdb");
                cmd = new OleDbCommand("UPDATE Personne SET id = id - 1 WHERE id > " + frmListePersonne.idASupprimer, connec);

                connec.Open();

                dr = cmd.ExecuteReader();

                connec.Close();

                lblNombrePersonne.Tag = int.Parse(lblNombrePersonne.Tag.ToString()) - 1; // Faire une fonction de mise à jour
                lblNombrePersonne.Text = "Nombre de personnes : " + lblNombrePersonne.Tag.ToString(); // Faire une fonction de mise à jour
            }
        } // /!\ Mise à jour à faire
    }
}
