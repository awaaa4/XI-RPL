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
    public partial class Form4Bandara : Form
    {
        public Form4Bandara()
        {
            InitializeComponent();
        }

        private void Form4Bandara_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboardForm = new Form3Dashboard();
            dashboardForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboardForm = new Form3Dashboard();
            dashboardForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapaiForm = new Form5Maskapai();
            maskapaiForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5Maskapai maskapaiForm = new Form5Maskapai();
            maskapaiForm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalForm = new Form6JadwalPenerbangan();
            jadwalForm.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalForm = new Form6JadwalPenerbangan();
            jadwalForm.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7KodePromo kodePromoForm = new Form7KodePromo();
            kodePromoForm.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7KodePromo kodePromoForm = new Form7KodePromo();
            kodePromoForm.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusForm = new Form8UbahStatusPenerbangan(); 
            ubahStatusForm.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusForm = new Form8UbahStatusPenerbangan();
            ubahStatusForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
