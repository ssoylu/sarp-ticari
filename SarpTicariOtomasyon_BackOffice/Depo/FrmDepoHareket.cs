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

namespace SarpTicariOtomasyon_BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {

        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private string _depoKodu;
        public FrmDepoHareket(string depoKodu,string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu; 
            lblBaslik.Text = depoKodu + "-" + depoAdi + " " + "Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridcontHareket.DataSource = stokHareketDal.GetAll(context,C=>C.DepoKodu==_depoKodu);
            gridcontDepoStok.DataSource = stokHareketDal.DepoStokListele(context,_depoKodu);
            gridcontIstatistik.DataSource = stokHareketDal.DepoIstatistikListele(context, _depoKodu);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void GridHareket_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                string Hareket = gridHareket.GetRowCellValue(e.RowHandle, colHareket).ToString();
                if (Hareket == "Stok Çıkış")
                {
                    e.Appearance.BackColor = Color.Red;
                    //e.Appearance.BackColor2 = Color.IndianRed;
                }
                else if (Hareket == "Stok Giriş")
                {
                    e.Appearance.BackColor = Color.Green;
                    //e.Appearance.BackColor2 = Color.LightGreen;
                }
            }
            catch (Exception)
            {


            }
        }
    }
}