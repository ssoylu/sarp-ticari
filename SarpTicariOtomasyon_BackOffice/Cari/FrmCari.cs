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
using SarpTicariOtomasyon_Entities.Tables;
using System.Data.SqlClient;

namespace SarpTicariOtomasyon_BackOffice.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        CariDAL cariDal = new CariDAL();
        public string secilen = null;
        public FrmCari()
        {
            InitializeComponent();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnFiltreiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                GetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void GetAll()
        {

            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            GetAll();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                    cariDal.Delete(context, c => c.CariKodu == secilen);
                    cariDal.Save(context);
                    GetAll();
                }

            }
            catch (Exception)
            {

                //throw;
            }
           
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           FrmCariIslem form = new FrmCariIslem(new SarpTicariOtomasyon_Entities.Tables.Cari());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
            
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu ==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            } 
        }

        private void BtnKopyala_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            SarpTicariOtomasyon_Entities.Tables.Cari CariEntitiy = new SarpTicariOtomasyon_Entities.Tables.Cari();
            CariEntitiy = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            CariEntitiy.Id = -1;
            CariEntitiy.CariKodu = null;
            FrmCariIslem form = new FrmCariIslem(CariEntitiy);
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void BtnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
            FrmCariHareket form = new FrmCariHareket(secilen, secilenAd);
            form.ShowDialog();
        }
    }
}