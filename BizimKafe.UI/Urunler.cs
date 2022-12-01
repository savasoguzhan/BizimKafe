using BizimKafe.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimKafe.UI
{
    public partial class Urunler : Form
    {
        private readonly KafeVeri _db;
        public Urunler(KafeVeri db)
        {
            InitializeComponent();
            _db = db;
            UrunleriListele();

        }

        private void UrunleriListele()
        {
            dgvUrunler.DataSource = _db.Urunler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "EKLE")
            {
                string ad = txtUrunAdi.Text.Trim();
                if (string.IsNullOrEmpty(ad))
                {
                    MessageBox.Show("Urun Adi Zorunlu.");
                    return;

                }
                _db.Urunler.Add(new Urun() { UrunAd = ad, BirimFiyat = nudBirimFiyat.Value });
                UrunleriListele();

            }
            else
            {
                DataGridViewRow satir = dgvUrunler.Rows[0];
                Urun urun = (Urun)satir.DataBoundItem;
                urun.BirimFiyat = nudBirimFiyat.Value;
                urun.UrunAd = txtUrunAdi.Text;
                UrunleriListele();
                btnEkle.Text = "EKLE";
                btnIptal.Enabled = false;
                txtUrunAdi.Clear();
                nudBirimFiyat.Value = 0;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Once Urun Seciniz.");
                return;
            }

            DialogResult dr = MessageBox.Show("Secili Urunu Silmek Istediginize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            DataGridViewRow satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            _db.Urunler.Remove(urun);
            UrunleriListele();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            btnIptal.Visible = true;
            btnEkle.Text = "KAYDET";
            DataGridViewRow satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            txtUrunAdi.Text = urun.UrunAd;
            nudBirimFiyat.Value = urun.BirimFiyat;

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnEkle.Text = "EKLE";
            btnIptal.Visible = false;
            txtUrunAdi.Clear();
            nudBirimFiyat.Value = 0;
        }
    }
}
