using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Init_WinForm
{
    public partial class Form1 : Form
    {
        public void Horloge()
        {
            string MonHeure = DateTime.Now.ToString("HH:mm:ss");
            LblTime.Text = MonHeure;
            //timer1.Enabled = true;
            return;
        }
        public Form1()
        {

            

            InitializeComponent();
        }

        private void CmdFermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Horloge();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Horloge();
        }
    }
}
