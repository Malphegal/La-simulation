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
    public partial class frmAjouterPersonne : Form
    {
            // Variables globales

        OleDbConnection connec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\BaseDeDonnée\bdLaSimulation.mdb");

            // Constructeurs

        public frmAjouterPersonne(string entiteAAjouter) // Constructeur
        {
            InitializeComponent();
            Text = "Ajouter : " + entiteAAjouter;
        }

            // --------------------------
            // Méthodes évenementielles
            // --------------------------

        private void btnAjouter_Click(object sender, EventArgs e) // Vérifier si tout les champs sont remplis
        {
            bool toutEstOK = true;
            errorProvider1.Clear();

            if (txtNom.Text.Length == 0) {
                toutEstOK = false;
                errorProvider1.SetIconPadding(txtNom, 4);
                errorProvider1.SetError(txtNom, "Il faut choisir un nom !");
            }
            if (txtPrenom.Text.Length == 0) {
                toutEstOK = false;
                errorProvider1.SetIconPadding(txtPrenom, 4);
                errorProvider1.SetError(txtPrenom, "Il faut choisir un prénom !");
            }
            if (txtAge.Text.Length == 0) {
                toutEstOK = false;
                errorProvider1.SetIconPadding(txtAge, 4);
                errorProvider1.SetError(txtAge, "Il faut indiquer un âge !");
            }
            if (!rdbFemme.Checked && !rdbHomme.Checked) {
                toutEstOK = false;
                errorProvider1.SetIconPadding(rdbFemme, 14);
                errorProvider1.SetError(rdbFemme, "Il faut choisir son sexe !");
            }
            if (toutEstOK)
            {
                Personne.ajouterUnePersonne(txtNom.Text, txtPrenom.Text, byte.Parse(txtAge.Text));

                    // Ajouter la Personne dans la table Personne

                using (var cmd = new OleDbCommand("INSERT INTO Personne VALUES (@ID, @NOM, @PRENOM, @SEXE, @AGE)", connec))
                {
                    connec.Open();

                    cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Personne.getAllPersonnes().Last().id;
                    cmd.Parameters.Add("@NOM", OleDbType.VarChar).Value = txtNom.Text;
                    cmd.Parameters.Add("@PRENOM", OleDbType.VarChar).Value = txtPrenom.Text;
                    cmd.Parameters.Add("@SEXE", OleDbType.VarChar).Value = rdbHomme.Checked ? "Homme" : "Femme";
                    cmd.Parameters.Add("@AGE", OleDbType.Integer).Value = int.Parse(txtAge.Text);

                    cmd.ExecuteNonQuery();
                }

                    // Ferme le formulaire

                DialogResult = DialogResult.OK;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) && txtAge.Text.Length < 3) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txtNom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != '-' && e.KeyChar != 8 && e.KeyChar != 18)
                e.Handled = true;
            if (e.KeyChar == 13)
                txtPrenom.Focus();
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != '-' && e.KeyChar != 8 && e.KeyChar != 18)
                e.Handled = true;
            if (e.KeyChar == 13)
                txtAge.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
