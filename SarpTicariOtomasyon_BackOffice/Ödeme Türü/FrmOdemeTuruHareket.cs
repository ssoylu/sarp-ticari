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
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Data_Access;

namespace SarpTicariOtomasyon_BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string _odemeTuruKodu;

        public FrmOdemeTuruHareket(string odemeTuruKodu,string odemeTuruAdi)
        {
            InitializeComponent();
            _odemeTuruKodu = odemeTuruKodu;
            lblBaslik.Text = odemeTuruKodu + "-" + odemeTuruAdi + " " + "Hareketleri";
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridcontKasaHareket.DataSource = odemeTuruDal.GetAll(context, c => c.OdemeTuruKodu == _odemeTuruKodu);
            gridcontKasalaraGoreBakiyeToplam.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruKodu);
            gridcontGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruKodu);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
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