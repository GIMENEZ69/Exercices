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
    public partial class F_Choix : Form
    {
        public F_Choix()
        {
            InitializeComponent();
        }

        private void F_Choix_Load(object sender, EventArgs e)
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
                string SqlQuery = "SELECT Id_Stagiaire,NomStag FROM TStagiaire";

                MaCommande.Connection = MaConnexion;
                MaCommande.CommandText = SqlQuery;
                SqlDataReader reader = MaCommande.ExecuteReader();
                reader.Read(); // lire la ligne en cours et passer à la suivante
                while(reader.Read())
                {
                    CBStagiaire.Items.Add(reader["Id_Stagiaire"] + "|" + reader["NomStag"]);
                }
                MaConnexion.Close();

            }
            catch (Exception d)
            {
                MessageBox.Show("Erreur rencontrée :" + d.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List :: NumStag|NomStag
            int monindex = CBStagiaire.Text.IndexOf("|");
            //MessageBox.Show("Index=" + Convert.ToString(monindex));
            Global.NumStag = int.Parse(CBStagiaire.Text.Substring(0, monindex));
            //MessageBox.Show("N° Stagiaire = "+ Convert.ToString(Global.NumStag));
            F_Affiche affstag = new F_Affiche();
            affstag.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form.ActiveForm.Close();
            }
        }
    }
    }

