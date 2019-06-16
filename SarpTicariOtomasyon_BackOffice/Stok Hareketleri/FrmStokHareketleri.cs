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

namespace SarpTicariOtomasyon_BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
           gridcontStokHareket.DataSource= stokHareketDal.GetAll(context);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
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

        private void RepoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir frmSeriNoGir = new FrmSeriNoGir(veri);
            FrmSeriNoGir form = frmSeriNoGir;
            form.kilitli = true;
            form.ShowDialog();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStokHareket_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFisIslem form = new FrmFisIslem(gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString());
                form.ShowDialog();
            }
            catch (Exception)
            {
             
               
                    MessageBox.Show("Her hangi Bir Kayıt bulunamadı");
                
            }
            
        }
    }
}
