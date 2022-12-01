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
    public partial class GecmisSiparisler : Form
    {
        private readonly KafeVeri _db;
        public GecmisSiparisler(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dgvGecmissiparisler.DataSource = _db.GecmisSiparisler;
        }

        private void dgvGecmissiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisDetaylari.SelectedRows.Count == 0)
            {
                dgvSiparisDetaylari.DataSource = null;
            }
            else
            {
                DataGridViewRow secilenSatir = dgvSiparisDetaylari.SelectedRows[0];
                Siparis secilenSiparis = (Siparis)secilenSatir.DataBoundItem;
                dgvSiparisDetaylari.DataSource = secilenSiparis.SiparisDetaylar;
            }
        }
    }
}
