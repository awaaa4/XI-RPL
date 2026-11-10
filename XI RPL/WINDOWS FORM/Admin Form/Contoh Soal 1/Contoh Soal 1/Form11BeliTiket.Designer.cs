namespace ContohSoal
{
    partial class Form11BeliTiket
    {



        private System.ComponentModel.IContainer components = null;





        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code





        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useBtn = new System.Windows.Forms.Button();
            this.departureLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.promoText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.maskapaiLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpPassenger = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(83, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mohon diisi data semua penumpang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(77, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detail Penumpang";
            // 
            // useBtn
            // 
            this.useBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.useBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useBtn.Location = new System.Drawing.Point(1132, 393);
            this.useBtn.Name = "useBtn";
            this.useBtn.Size = new System.Drawing.Size(108, 34);
            this.useBtn.TabIndex = 9;
            this.useBtn.Text = "Pakai";
            this.useBtn.UseVisualStyleBackColor = false;
            this.useBtn.Click += new System.EventHandler(this.useBtn_Click);
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.departureLabel.Location = new System.Drawing.Point(789, 68);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(185, 25);
            this.departureLabel.TabIndex = 7;
            this.departureLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(789, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Penerbangan";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payBtn.Location = new System.Drawing.Point(794, 555);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(446, 44);
            this.payBtn.TabIndex = 9;
            this.payBtn.Text = "Konfirmasi Pembayaran";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(789, 513);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 28);
            this.label18.TabIndex = 7;
            this.label18.Text = "Total Pembayaran";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.priceLabel.Location = new System.Drawing.Point(270, 510);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(207, 32);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "IDR XX.XXX.XXX";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(789, 362);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 28);
            this.label20.TabIndex = 7;
            this.label20.Text = "Kode Promo";
            // 
            // promoText
            // 
            this.promoText.BackColor = System.Drawing.SystemColors.Window;
            this.promoText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoText.Location = new System.Drawing.Point(794, 393);
            this.promoText.Name = "promoText";
            this.promoText.Size = new System.Drawing.Size(332, 34);
            this.promoText.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(789, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 28);
            this.label21.TabIndex = 7;
            this.label21.Text = "Detail Penerbangan";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel.Location = new System.Drawing.Point(825, 213);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(191, 25);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Monday, 22 May 2023";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeLabel.Location = new System.Drawing.Point(825, 251);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(117, 25);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "19:50 - 21:25";
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passengerLabel.Location = new System.Drawing.Point(825, 288);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(124, 25);
            this.passengerLabel.TabIndex = 7;
            this.passengerLabel.Text = "5 penumpang";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.destinationLabel.Location = new System.Drawing.Point(1008, 68);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(185, 25);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Soekarno-Hatta (CGK)";
            // 
            // maskapaiLabel
            // 
            this.maskapaiLabel.AutoSize = true;
            this.maskapaiLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskapaiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maskapaiLabel.Location = new System.Drawing.Point(789, 100);
            this.maskapaiLabel.Name = "maskapaiLabel";
            this.maskapaiLabel.Size = new System.Drawing.Size(140, 25);
            this.maskapaiLabel.TabIndex = 7;
            this.maskapaiLabel.Text = "Pelita Air Service";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Location = new System.Drawing.Point(763, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 629);
            this.panel1.TabIndex = 13;
            // 
            // flpPassenger
            // 
            this.flpPassenger.AutoScroll = true;
            this.flpPassenger.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPassenger.Location = new System.Drawing.Point(-2, 128);
            this.flpPassenger.Name = "flpPassenger";
            this.flpPassenger.Size = new System.Drawing.Size(769, 500);
            this.flpPassenger.TabIndex = 14;
            this.flpPassenger.WrapContents = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Contoh_Soal_1.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_35_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(794, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contoh_Soal_1.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_37_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(794, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Contoh_Soal_1.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_35_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(976, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Contoh_Soal_1.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_36_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(794, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Contoh_Soal_1.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_35__2__removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(25, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 44);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Form11BeliTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 627);
            this.Controls.Add(this.promoText);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.useBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.maskapaiLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpPassenger);
            this.Name = "Form11BeliTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11BeliTiket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form11BeliTiket_FormClosing);
            this.Load += new System.EventHandler(this.Form11BeliTiket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button useBtn;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox promoText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label maskapaiLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpPassenger;
    }
}