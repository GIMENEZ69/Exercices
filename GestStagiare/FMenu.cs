using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestStagiare
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security = SSPI";

            try
            {
                // Ouverture de la connexion à SQLServer
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                //MessageBox.Show("MaConnexion Ouverte");
                // MessageBox.Show(" MaConnecxion Ouverte ");
                SqlCommand MaCommande = new SqlCommand();
                string SqlQuery = "SELECT count(Id_Stagiaire) as nbstag FROM TStagiaire";

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();
                reader.Read(); // lire la ligne en cours et passer à la suivante
                SL.Text = "Nombre de stagiaire = "+Convert.ToString( reader["nbstag"]);
                MaConnexion.Close();

            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" + d.Message);
            }
        }

        private void gestionStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
            
        

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cretionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCreationStag creastag = new FCreationStag();
            creastag.ShowDialog();
        }

        private void ficheStagiareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Choix  fchoix = new F_Choix();
            fchoix.ShowDialog();
            
        }

        private void listeStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Affiche_Auto faffiche = new F_Affiche_Auto();
            faffiche.ShowDialog();
        }

      
    }
}
