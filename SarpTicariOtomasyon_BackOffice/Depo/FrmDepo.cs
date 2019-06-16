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
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        DepoDAL depoDal = new DepoDAL();
        private string secilen = null;
        public FrmDepo()
        {
            InitializeComponent();
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }
        private void Listele()
        {
            gridcontDepolar.DataSource = depoDal.GetAll(context);
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                    depoDal.Delete(context, c => c.DepoKodu == secilen);
                    depoDal.Save(context);
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
            FrmDepoKartiIşlemleri form = new FrmDepoKartiIşlemleri(new SarpTicariOtomasyon_Entities.Tables.Depo());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            FrmDepoKartiIşlemleri form = new FrmDepoKartiIşlemleri(depoDal.GetByFilter(context, c => c.DepoKodu == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnDepoHareket_Click(object sender, EventArgs e)
        {
            //secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            //string secilenAd = gridDepolar.GetFocusedRowCellValue(colDepoAdi).ToString();
            //FrmCariHareket form = new FrmCariHareket(secilen, secilenAd);
            //form.ShowDialog();
        }

        private void BtnDepoHareket_Click_1(object sender, EventArgs e)
        {
            secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            string secilenAd = gridDepolar.GetFocusedRowCellValue(colDepoAdi).ToString();
            FrmDepoHareket form = new FrmDepoHareket(secilen, secilenAd);
            form.ShowDialog();
        }
    }
}