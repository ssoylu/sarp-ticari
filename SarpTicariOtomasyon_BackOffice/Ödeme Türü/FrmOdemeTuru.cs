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

namespace SarpTicariOtomasyon_BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext Context = new SarpTicariOtomasyonContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string secilen = null;
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }

        void Listele()
        {
            gridcontOdemeTuru.DataSource = odemeTuruDal.OdemeTuruListele(Context);
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

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string secilen = gridOdmeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                    odemeTuruDal.Delete(Context, c => c.OdemeTuruKodu == secilen);
                    odemeTuruDal.Save(Context);
                    Listele();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hatalı İşlem.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new OdemeTuru());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridOdmeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(odemeTuruDal.GetByFilter(Context,c=>c.OdemeTuruKodu==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnStokHareket_Click(object sender, EventArgs e)
        {
            try
            {
                secilen = gridOdmeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                string secilenAd = gridOdmeTuru.GetFocusedRowCellValue(colOdemeTuruAdi).ToString();
                FrmOdemeTuruHareket form = new FrmOdemeTuruHareket(secilen, secilenAd);
                form.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
    }
}