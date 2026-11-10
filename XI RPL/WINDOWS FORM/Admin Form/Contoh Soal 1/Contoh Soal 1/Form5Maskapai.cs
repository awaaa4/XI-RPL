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
    public partial class Form5Maskapai : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idMaskapai = -1;

        public Form5Maskapai()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4Bandara bandaraForm = new Form4Bandara();
            bandaraForm.Show();
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

        private void Form5Maskapai_Load(object sender, EventArgs e)
        {
            dataGridMaskapai.AutoGenerateColumns = false;
            dataGridMaskapai.AllowUserToAddRows = false;
            dataGridMaskapai.ReadOnly = true;
            LoadMaskapai();
        }

        private void LoadMaskapai()
        {
            dataGridMaskapai.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList();
        }

        private void ClearForm()
        {
            nameTxt.Clear();
            companyTxt.Clear();
            descriptionTxt.Clear();

            crewCount.Value = 0;
            idMaskapai = -1;
            saveBtn.Text = "Simpan";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi isi textbox
            if (nameTxt.Text == "" || companyTxt.Text == "" || descriptionTxt.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            // validasi jumlah kru
            if (crewCount.Value < 1)
            {
                MessageBox.Show("Jumlah kru minimal 1!");
                return;
            }

            // percabangan add / update
            if (idMaskapai == -1) // add
            {
                Maskapai maskapaiBaru = new Maskapai();
                maskapaiBaru.Nama = nameTxt.Text;
                maskapaiBaru.Perusahaan = companyTxt.Text;
                maskapaiBaru.JumlahKru = Convert.ToInt32(crewCount.Value);
                maskapaiBaru.Deskripsi = descriptionTxt.Text;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("Data berhasil ditambahkan");

            }
            else // update
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);

                editMaskapai.Nama = nameTxt.Text;
                editMaskapai.Perusahaan = companyTxt.Text;
                editMaskapai.JumlahKru = Convert.ToInt32(crewCount.Value);
                editMaskapai.Deskripsi = descriptionTxt.Text;

                MessageBox.Show("Berhasil mengubah data maskapai");
            }

            db.SaveChanges();
            LoadMaskapai();
            ClearForm();
        }

        private void dataGridMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "edit")
            {
                idMaskapai = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                nameTxt.Text = editMaskapai.Nama;
                companyTxt.Text = editMaskapai.Perusahaan;
                crewCount.Value = editMaskapai.JumlahKru;
                descriptionTxt.Text = editMaskapai.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridMaskapai.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridMaskapai.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai);
                    db.SaveChanges();

                    MessageBox.Show("Maskapai berhasil dihapus");
                    LoadMaskapai();
                    ClearForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
