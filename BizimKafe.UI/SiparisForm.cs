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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            InitializeComponent();
            BilgileriGuncelle();
            UrunleriListele();


        }

        private void UrunleriListele()
        {
            cbUrun.DataSource = _db.Urunler;
        }

        private void BilgileriGuncelle()
        {
            Text = $"Masa{_siparis.MasaNo}";
            lblMasano.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutar.Text = _siparis.ToplamTutarTL;
            dgvSiparisDetaylar.DataSource = _siparis.SiparisDetaylar.ToList();
            MasaNolariYukle();
        }

        private void MasaNolariYukle()
        {
            cbMasaNo.Items.Clear();

            for (int i = 1; i <= _db.MasaAdet; i++)
            {
                if (_db.AktifSiparisler.Any(x => x.MasaNo == i))
                {
                    cbMasaNo.Items.Add(i);


                }

            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cbUrun.SelectedItem;
            if (urun == null)
                return;

            SiparisDetay sd = _siparis.SiparisDetaylar.FirstOrDefault(x => x.UrunAd == urun.UrunAd);

            if (sd != null)
            {
                sd.Adet += (int)nudAdet.Value;
            }
            else
            {
                sd = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nudAdet.Value,


                };

                _siparis.SiparisDetaylar.Add(sd);
            }

            BilgileriGuncelle();

        }

        private void btnAnasayfaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.OdenenTutar = _siparis.ToplamTutar();
            _siparis.Durum = SiparisDurum.Odendi;

            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.OdenenTutar = 0;
            _siparis.Durum = SiparisDurum.iptal;

            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);

            DialogResult = DialogResult.OK;
            Close();

        }

        private void SiparisKapat(decimal odenenTutar, SiparisDurum yeniDurum)
        {
            _siparis.KapanisZamani = DateTime.Now;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.Durum = yeniDurum;

            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);

            DialogResult = DialogResult.OK;
        }
    }
}
