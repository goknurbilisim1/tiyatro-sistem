using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi = new List<Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro(1, "Bekçi ile Postacı", new DateTime(2023, 12, 24),240, "Rasim Öztekin Sahnesi",40.50,true));
            tiyatroListesi.Add(new Tiyatro(2, "12. Gece", new DateTime(2023, 12, 25), 145, "Rasim Öztekin Sahnesi", 49.99, false));

            dgvListe.DataSource = tiyatroListesi.ToList();

        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            dtpTarih.Value =(DateTime) dgvListe.CurrentRow.Cells["tarih"].Value;
            nmSure.Value = Convert.ToInt32(dgvListe.CurrentRow.Cells["sure"].Value);
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string ad=cmbAd.Text;
            DateTime tarih=dtpTarih.Value;
            Decimal sure = nmSure.Value;
            string sahne=cmbSahne.Text;
            double fiyat =Convert.ToDouble(txtFiyat.Text);
            bool muzikal=chkMuzikal.Checked;

            Tiyatro yeniTiyatro = new Tiyatro(id, ad, tarih, sure, sahne, fiyat, muzikal);
            tiyatroListesi.Add(yeniTiyatro);

            dgvListe.DataSource = tiyatroListesi.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro=secilenSatir.DataBoundItem as Tiyatro;
            DialogResult=MessageBox.Show("Seçilen Tiyatro silinsin mi?","Tiyatro Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secilenTiyatro);
            }
            dgvListe.DataSource = tiyatroListesi.ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro = secilenSatir.DataBoundItem as Tiyatro;
            int id = Convert.ToInt32(txtId.Text);
            string ad=cmbAd.Text;
            DateTime tarih = dtpTarih.Value;
            decimal sure=nmSure.Value;
            string sahne = cmbSahne.Text;
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            bool muzikal = chkMuzikal.Checked;



            secilenTiyatro.Id=id;
            secilenTiyatro.Ad=ad;
            secilenTiyatro.Tarih=tarih;
            secilenTiyatro.Sure=sure;
            secilenTiyatro.Sahne = sahne;
            secilenTiyatro.Fiyat=fiyat;
            secilenTiyatro.Muzikal=muzikal;

            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroListesi.ToList();
        }

    }
}
