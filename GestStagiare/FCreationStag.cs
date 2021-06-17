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
    public partial class FCreationStag : Form
    {
        public FCreationStag()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void TxtStag_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaineDeConnexion = "Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security = SSPI";

                try
                {
                // Ouverture de la connexion à SQLServer
                SqlConnection MaConnexion = new SqlConnection(chaineDeConnexion);
                MaConnexion.Open();
                MessageBox.Show("MaConnexion Ouverte");
                // MessageBox.Show(" MaConnecxion Ouverte ")

                // Insertion des données avec une requete préparée ( ou parametrée )
                SqlCommand commande = MaConnexion.CreateCommand();
                // requête paramatrée
                commande.CommandText = "INSERT INTO TStagiaire(Id_Stagiaire,NomStag,PrenomStag,Section,DateNaissance)" +
                    " VALUES(@Id,@Nom,@Prenom,@Section,@DateNaissance) ";

                //binding parametres

                //parametres @Id
                SqlParameter paramId = new SqlParameter("@Id", TxtStag.Text);
                paramId.Direction = ParameterDirection.Input;
                paramId.DbType = DbType.Int32;

                // Parametre @Nom
                SqlParameter paramNom = new SqlParameter("@Nom", TxtNom.Text);
                paramNom.Direction = ParameterDirection.Input;
                paramNom.DbType = DbType.String;
                paramNom.Size = 30;

                // Parametres @Prenom
                SqlParameter paramPrenom = new SqlParameter("@Prenom", TxtPrenom.Text);
                paramPrenom.Direction = ParameterDirection.Input;
                paramPrenom.DbType = DbType.String;
                paramNom.Size = 20;

                // Parametres @Section
                SqlParameter paramSection = new SqlParameter("@Section", TxtSection.Text);
                paramSection.Direction = ParameterDirection.Input;
                paramSection.DbType = DbType.String;
                paramSection.Size = 5;

                //parametres @datenaissance
                DateTime MaDate = Convert.ToDateTime(DTPNaissance.Value);
                SqlParameter paramDate = new SqlParameter("@datenaissance", MaDate);
                paramDate.Direction = ParameterDirection.Input;
                paramDate.DbType = DbType.DateTime;

                //envoyer les parametres dans la requête
                commande.Parameters.Add(paramId);
                commande.Parameters.Add(paramNom);
                commande.Parameters.Add(paramPrenom);
                commande.Parameters.Add(paramSection);
                commande.Parameters.Add(paramDate);

                //execution de la requete parametrée
                commande.ExecuteNonQuery();
                //fermeture connexion SQL Server
                MaConnexion.Close();

                TxtStag.Text = "";
                TxtNom.Text = "";
                TxtPrenom.Text = "";
                TxtSection.Text = "";


            }
                catch(Exception d)
                {
                    MessageBox.Show("Erreur : "+d.Message);
                 }
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTPNaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
