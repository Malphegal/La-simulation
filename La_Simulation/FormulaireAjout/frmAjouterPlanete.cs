using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Simulation.FormulaireAjout
{
    public partial class frmAjouterPlanete : Form
    {
        public frmAjouterPlanete()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
