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
    public partial class F_Affiche : Form
    {
        public F_Affiche()
        {
            InitializeComponent();
        }

        private void F_Affiche_Load(object sender, EventArgs e)
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
                string SqlQuery = "SELECT * FROM TStagiaire WHERE Id_Stagiaire="+ Global.NumStag;

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();
                reader.Read(); // lire la ligne en cours et passer à la suivante

                TxtStag.Text = Convert.ToString(reader["Id_Stagiaire"]);
                TxtNom.Text = (string)reader["NomStag"];
                TxtPrenom.Text = (string)reader["PrenomStag"];
                TxtSection.Text = (string)reader["Section"];
                DTPNaissance.Value = (DateTime)reader["DateNaissance"];

                MaConnexion.Close();
            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" + d.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
