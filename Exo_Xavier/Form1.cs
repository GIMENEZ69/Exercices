using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_Xavier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saisie.Text != "")
            {
                listBox1.Items.Add(saisie.Text);
                saisie.Focus();
                saisie.Clear();
            }
            else
            {
                MessageBox.Show("SVP entrer un nom valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saisie.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >=0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Focus();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex>=0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Focus();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
    }
}
