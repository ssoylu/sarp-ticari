using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SarpTicariOtomasyon_Entities.Data_Access;
using SarpTicariOtomasyon_Entities.Context;

namespace SarpTicariOtomasyon_BackOffice.Kasa
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        private string _kasaKodu;

        public FrmKasaHareketleri(string kasaKodu,string kasaAdi)
        {
            InitializeComponent();
            _kasaKodu = kasaKodu;
            lblBaslik.Text = kasaKodu + "-" + kasaAdi + " " + "Hareketleri";
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridcontKasaHareket.DataSource = kasaDal.GetAll(context, c => c.KasaKodu == _kasaKodu);
            gridcontOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaKodu);
            gridcontGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaKodu);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}