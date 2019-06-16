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
using SarpTicariOtomasyon_BackOffice.Fiş;

namespace SarpTicariOtomasyon_BackOffice.Kasa_Hareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        KasaHareketDAL KasaHareketDal = new KasaHareketDAL();
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            gridcontKasaHareket.DataSource = KasaHareketDal.GetAll(context);
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }


        private void BtnFiltreiptal_Click_1(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void BtnFiltrele_Click_1(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void SimpleButton1_Click_1(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAra_Click_1(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnStokHareket_Click_1(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }
    }
}