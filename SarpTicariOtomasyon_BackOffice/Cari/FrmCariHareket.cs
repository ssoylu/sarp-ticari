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

namespace SarpTicariOtomasyon_BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        private string _cariKodu=null;
        public FrmCariHareket(string cariKodu,string cariAdi)
        {
            InitializeComponent();
            _cariKodu = cariKodu;
            lblBaslik.Text = _cariKodu + "-" + cariAdi + " " + "Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridcontFisToplam.DataSource= cariDal.CariFisGenelToplam(context, _cariKodu);
            gridcontBakiye.DataSource = cariDal.CariGenelToplam(context, _cariKodu);
            gridcontCariHareket.DataSource = cariDal.CariFisAyrinti(context, _cariKodu);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}