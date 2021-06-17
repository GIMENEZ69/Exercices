using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Devin
{
    public partial class Form1 : Form
    {
        public int MonTirage;
        public int NbTour = 0;

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        string Resultat(string MonNombre)
        {
            int MonNombre2 = int.Parse(MonNombre);
            string MaChaine = "";
            if (MonNombre2< MonTirage)
            {
                MaChaine = MonNombre + " est inférieur au tirage";
            }
            else if (MonNombre2>MonTirage)
            {
                MaChaine = MonNombre + " est supérieur au tirage";
            }
            else
            {
                MaChaine = " Gagné, vous avez trouvé";
                CmdOK.Enabled = false;
                CmdInit.Enabled = true;
            
            }
            return MaChaine;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MonTirage = RandomNumber(1, 9999);
            label14.Text = Convert.ToString(MonTirage);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            // Controle de saisi
            if (textBox2.Text=="")
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !!!");
                textBox2.Focus();
                return;
            }
            else if (!Int32.TryParse(textBox2.Text,out n))
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !!!");
                textBox2.Focus();
                return;
            }
            else if(int.Parse(textBox2.Text)< 1 || int.Parse(textBox2.Text)> 9999)
            {
                MessageBox.Show("Vous devez saisir un nombre entre 1 et 9999 !!!");
                textBox2.Focus();
                return;
            }


            NbTour++;
            switch(NbTour)
            {
                case 1:
                    label2.Text = Resultat(textBox2.Text);
                    break;
                case 2:
                    label3.Text = Resultat(textBox2.Text);
                    break;
                case 3:
                    label4.Text = Resultat(textBox2.Text);
                    break;
                case 4:
                    label5.Text = Resultat(textBox2.Text);
                    break;
                case 5:
                    label6.Text = Resultat(textBox2.Text);
                    break;
                case 6:
                    label7.Text = Resultat(textBox2.Text);
                    break;
                case 7:
                    label8.Text = Resultat(textBox2.Text);
                    break;
                case 8:
                    label9.Text = Resultat(textBox2.Text);
                    break;
                case 9:
                    label10.Text = Resultat(textBox2.Text);
                    break;
                case 10:
                    label11.Text = Resultat(textBox2.Text);
                    break;
                case 11:
                    label12.Text = Resultat(textBox2.Text);
                    break;
                case 12:
                    label13.Text = Resultat(textBox2.Text);
                    break;
            }
            textBox2.Text ="";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CmdInit_Click(object sender, EventArgs e)
        {
            MonTirage = RandomNumber(1, 9999);
            label14.Text = Convert.ToString(MonTirage);
            CmdInit.Enabled = false;
            CmdOK.Enabled = true;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            NbTour = 0;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
    }
}
