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
using DevExpress.XtraGrid.Views.Grid;

namespace SarpTicariOtomasyon_BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        private string _stokKodu;
        //private int i;

        public FrmStokHareket(string stokKodu,string stokadi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            lblBaslik.Text = _stokKodu + "-" + stokadi +" "+ "Hareketleri";
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Güncelle();
            

        }

        

        private void Güncelle()
        {
            gridconStokHareket.DataSource = stokHareketDAL.GetAll(context, c => c.StokKodu == _stokKodu);
            gridconGenelStok.DataSource = stokHareketDAL.GetGenelStok(context, _stokKodu);
            gridconDepoStok.DataSource = stokHareketDAL.GetDepoStok(context, _stokKodu);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Güncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
            
        }

        private void GridStokHareket_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                string Hareket = gridStokHareket.GetRowCellValue(e.RowHandle, colHareket).ToString();
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

        private void GridGenelStok_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                string Hareket = gridGenelStok.GetRowCellValue(e.RowHandle, colGenelBilgi).ToString();
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