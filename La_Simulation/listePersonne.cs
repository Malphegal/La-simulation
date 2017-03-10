using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace La_Simulation
{
    public partial class frmListePersonne : Form
    {
            // Variables globales

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\BaseDeDonnée\bdLaSimulation.mdb");
        static public int idASupprimer { get; private set; }

            // Constructeur

        public frmListePersonne() // Constructeur
        {
            InitializeComponent();
        }

            // --------------------------
            // Méthodes évenementielles
            // --------------------------

        private void listePersonne_Load(object sender, EventArgs e)
        {
            using (var cmd = new OleDbCommand("SELECT * FROM Personne", connec))
            {
                connec.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    cboListePersonne.Items.Add("[" + dr.GetValue(0).ToString() + "] " + dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString() +
                        "(" + dr.GetValue(3).ToString() + ") " + dr.GetValue(4).ToString() + (int.Parse(dr.GetValue(4).ToString()) > 1 ? " ans" : " an"));
            }
        } // Remplir cboListePersonne avec toutes les Personnes

        private void btnQuitter_Click(object sender, EventArgs e) // Ferme le formulaire de choix de Personne
        {
            Close();
        }        

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cboListePersonne.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer de la base de donnée :\n" + cboListePersonne.SelectedItem + " ?", "Confirmer la suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idASupprimer = cboListePersonne.SelectedIndex;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
