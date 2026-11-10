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
    public partial class Form8UbahStatusPenerbangan : Form
    {

        BandaraEntities db = new BandaraEntities();
        private int idStatus;

        public Form8UbahStatusPenerbangan()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Form4Bandara bandaraForm = new Form4Bandara();
            bandaraForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4Bandara bandaraForm = new Form4Bandara();
            bandaraForm.Show();
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

        private void LoadStatus()
        {
            statusBox.DataSource = db.StatusPenerbangans.ToList();
            statusBox.ValueMember = "ID";
            statusBox.DisplayMember = "Nama";
            statusBox.SelectedIndex = -1;
        }

        private void LoadData()
        {
            dataGridStatus.DataSource = db.PerubahanStatusJadwalPenerbangans.Select(s => new
            {
                s.ID,
                s.JadwalPenerbanganID,
                kodePenerbangan = s.JadwalPenerbangan.KodePenerbangan,
                bandaraAwal = s.JadwalPenerbangan.Bandara.Nama,
                bandaraTujuan = s.JadwalPenerbangan.Bandara1.Nama,
                maskapai = s.JadwalPenerbangan.Maskapai.Nama,
                tanggalKeberangkatan = s.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                durasiPenerbangan = (s.JadwalPenerbangan.DurasiPenerbangan / 60) + " Jam " + (s.JadwalPenerbangan.DurasiPenerbangan % 60) + " Menit ",
                statusPenerbangan = s.StatusPenerbangan.Nama,
                s.WaktuPerubahanTerjadi
            }).ToList();
        }

        private void dataGridStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
