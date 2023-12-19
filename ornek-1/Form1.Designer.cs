namespace ornek_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.chkMuzikal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmSure = new System.Windows.Forms.NumericUpDown();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun-Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun-Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Süre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(394, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fiyat:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(90, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(455, 49);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 26);
            this.txtFiyat.TabIndex = 7;
            // 
            // cmbAd
            // 
            this.cmbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Items.AddRange(new object[] {
            "Güvercin ve Postacı",
            "Fındıkkıran",
            "Çöpsüz Dünya",
            "Benim Güzel Pabuçlarım",
            "Benim Küçük Yıldızım",
            "Bir Gece Masalı"});
            this.cmbAd.Location = new System.Drawing.Point(90, 55);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(199, 28);
            this.cmbAd.TabIndex = 8;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(89, 95);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 26);
            this.dtpTarih.TabIndex = 9;
            // 
            // chkMuzikal
            // 
            this.chkMuzikal.AutoSize = true;
            this.chkMuzikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMuzikal.Location = new System.Drawing.Point(455, 81);
            this.chkMuzikal.Name = "chkMuzikal";
            this.chkMuzikal.Size = new System.Drawing.Size(81, 24);
            this.chkMuzikal.TabIndex = 11;
            this.chkMuzikal.Text = "Müzikal";
            this.chkMuzikal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(381, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sahne:";
            // 
            // cmbSahne
            // 
            this.cmbSahne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "Gaziosmanpaşa Egemen Çocuk Tiyatrosu",
            "Gaziosmanpaşa Sahnesi",
            "Fatih Reşat Nuri Sahnesi",
            "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi",
            "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu",
            "İBB Yenibosna Dr. Enver Ören Kültür Merkezi"});
            this.cmbSahne.Location = new System.Drawing.Point(455, 16);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(204, 28);
            this.cmbSahne.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmSure);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSahne);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkMuzikal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cmbAd);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 233);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiyatro Bilgi Girişi";
            // 
            // nmSure
            // 
            this.nmSure.Location = new System.Drawing.Point(90, 132);
            this.nmSure.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nmSure.Name = "nmSure";
            this.nmSure.ReadOnly = true;
            this.nmSure.Size = new System.Drawing.Size(120, 20);
            this.nmSure.TabIndex = 18;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::ornek_1.Properties.Resources._003_bin;
            this.btnSil.Location = new System.Drawing.Point(601, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 79);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::ornek_1.Properties.Resources._001_refresh;
            this.btnGuncelle.Location = new System.Drawing.Point(490, 124);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 79);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Image = global::ornek_1.Properties.Resources._002_diskette;
            this.btnEkle.Location = new System.Drawing.Point(373, 124);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 79);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 251);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(775, 200);
            this.dgvListe.TabIndex = 16;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.CheckBox chkMuzikal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.NumericUpDown nmSure;
    }
}

