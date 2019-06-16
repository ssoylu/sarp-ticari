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
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        private string secilen = null;

        public FrmKasa()
        {
            InitializeComponent();
        }
        public void Guncelle()
        {
            gridcontKasalar.DataSource = kasaDal.GetKasa(context);
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormKasaIslemleri form = new FormKasaIslemleri(new SarpTicariOtomasyon_Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                FormKasaIslemleri form = new FormKasaIslemleri(kasaDal.GetByFilter(context, c => c.KasaKodu == secilen));
                form.ShowDialog();
                if (form.Kaydedildi)
                {
                    Guncelle();
                }
            }
            catch (Exception)
            {

               
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                    kasaDal.Delete(context, c => c.KasaKodu == secilen);
                    kasaDal.Save(context);
                    Guncelle();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hatalı İşlem.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            try
            {
                secilen = layoutView1.GetFocusedRowCellValue(colKasaKodu).ToString();
                string secilenAd = layoutView1.GetFocusedRowCellValue(colKasaAdi).ToString();
                FrmKasaHareket form = new FrmKasaHareket(secilen, secilenAd);
                form.ShowDialog();
            }
            catch (Exception)
            {

               
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}