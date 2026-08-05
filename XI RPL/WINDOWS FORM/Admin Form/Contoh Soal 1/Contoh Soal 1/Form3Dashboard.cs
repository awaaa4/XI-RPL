using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_Soal_1
{
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1Login loginForm = new Form1Login();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1Login loginForm = new Form1Login();
            loginForm.Show();
            this.Close();
        }
    }
}
