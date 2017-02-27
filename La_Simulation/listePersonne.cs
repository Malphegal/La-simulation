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
        public frmListePersonne() 
        {
            InitializeComponent();
        } // Constructeur

        private void listePersonne_Load(object sender, EventArgs e)
        {
            OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Anacin\Desktop\La_Simulation\La_Simulation\BaseDeDonnée\bdLaSimulation.mdb");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Personne", connec);

            connec.Open();

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                cboListePersonne.Items.Add("[" + dr.GetValue(0).ToString() + "] " + dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString() +
                    "(" + dr.GetValue(3).ToString() + ") " + dr.GetValue(4).ToString() + " an" + (int.Parse(dr.GetValue(0).ToString()) > 1 ? "s" : ""));

            connec.Close();
        } // Remplir cboListePersonne avec toutes les Personnes

        private void btnQuitter_Click(object sender, EventArgs e) // Ferme le formulaire de choix de Personne
        {
            Close();
        }

        static private int id;
        static public int idASupprimer { get { return id; } }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cboListePersonne.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer de la base de donnée\n" + cboListePersonne.SelectedItem + " ?", "Confirmer la suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    id = cboListePersonne.SelectedIndex;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
