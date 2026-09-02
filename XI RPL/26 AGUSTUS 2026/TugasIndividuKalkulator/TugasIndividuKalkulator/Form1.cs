using System;
using System.Globalization;
using System.Windows.Forms;

namespace TugasIndividuKalkulator
{
    public partial class Form1 : Form
    {
        double angkaPertama = 0;
        string operasi = "";
        bool operasiDitekan = false;

        public Form1()
        {
            InitializeComponent();

            txtDisplay.Text = "0";
        }

        // TOMBOL ANGKA
        private void Angka_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (txtDisplay.Text == "0" || operasiDitekan)
            {
                txtDisplay.Text = tombol.Text;
                operasiDitekan = false;
            }
            else
            {
                txtDisplay.Text += tombol.Text;
            }
        }

        // =========================
        // TOMBOL OPERASI
        // =========================
        private void Operasi_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;

            if (double.TryParse(txtDisplay.Text, out angkaPertama))
            {
                operasi = tombol.Text;
                operasiDitekan = true;
            }
        }

        // =========================
        // TOMBOL =
        // =========================
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double angkaKedua;

            if (!double.TryParse(txtDisplay.Text, out angkaKedua))
            {
                MessageBox.Show("Angka tidak valid!");
                return;
            }

            double hasil = 0;

            switch (operasi)
            {
                case "+":
                    hasil = angkaPertama + angkaKedua;
                    break;

                case "-":
                case "−":
                    hasil = angkaPertama - angkaKedua;
                    break;

                case "*":
                case "×":
                    hasil = angkaPertama * angkaKedua;
                    break;

                case "/":
                case "÷":

                    if (angkaKedua == 0)
                    {
                        MessageBox.Show("Tidak bisa membagi dengan 0!");
                        return;
                    }

                    hasil = angkaPertama / angkaKedua;
                    break;

                default:
                    return;
            }

            txtDisplay.Text = hasil.ToString();
            operasi = "";
            operasiDitekan = true;
        }

        // =========================
        // AC
        // =========================
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            angkaPertama = 0;
            operasi = "";
            operasiDitekan = false;
        }

        // =========================
        // PLUS / MINUS
        // =========================
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double angka))
            {
                angka = angka * -1;
                txtDisplay.Text = angka.ToString();
            }
        }

        // =========================
        // PERSEN
        // =========================
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double angka))
            {
                angka = angka / 100;
                txtDisplay.Text = angka.ToString();
            }
        }

        // =========================
        // KOMA
        // =========================
        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }
        }
    }
}