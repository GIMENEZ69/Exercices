using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiare
{
    public partial class F_Affiche_Auto : Form
    {
        public F_Affiche_Auto()
        {
            InitializeComponent();
        }

        private void F_Affiche_Auto_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'stagiairesDataSet.TStagiaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tStagiaireTableAdapter.Fill(this.stagiairesDataSet.TStagiaire);
            dataGridView1.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form.ActiveForm.Close();
            }
        }
    }
}
