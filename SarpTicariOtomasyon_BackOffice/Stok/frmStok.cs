using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_Entities.Data_Access;

namespace SarpTicariOtomasyon_BackOffice.Stok
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        StokDAL stokDal = new StokDAL();
        private string secilen=null;
        public frmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e){
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }
        public void Listele()
        {

            gridConStok.DataSource = stokDal.GetAlljoin(context);
          //gridConStok.DataSource = depoDal.GetAll(context);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void BtnFiltreiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string secilen = gridViewStok.GetFocusedRowCellValue(colStokKodu).ToString();
                    stokDal.Delete(context,c =>c.StokKodu == secilen);
                    stokDal.Save(context);
                    Listele();
                }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            frmStokislem form = new frmStokislem(new SarpTicariOtomasyon_Entities.Tables.Stok());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridViewStok.GetFocusedRowCellValue(colStokKodu).ToString();
            frmStokislem form = new frmStokislem(stokDal.GetByFilter(context,c=>c.StokKodu==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridViewStok.GetFocusedRowCellValue(colStokKodu).ToString();
            SarpTicariOtomasyon_Entities.Tables.Stok StokEntitiy = new SarpTicariOtomasyon_Entities.Tables.Stok();
            StokEntitiy = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            StokEntitiy.Id = -1;
            StokEntitiy.StokKodu = null;
            frmStokislem form = new frmStokislem(StokEntitiy);
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = gridViewStok.GetFocusedRowCellValue(colStokKodu).ToString();
            string secilenAd = gridViewStok.GetFocusedRowCellValue(colStokAdi).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen,secilenAd);
            form.ShowDialog();    
        }
    }
}