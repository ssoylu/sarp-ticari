using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Data_Access;

namespace SarpTicariOtomasyon_BackOffice.Personeller
{
    public partial class FrmPersonel : Form
    {
        SarpTicariOtomasyonContext context=new SarpTicariOtomasyonContext();
        PersonelDAL personelDal=new PersonelDAL();
        private string _secilen=null ;
        

        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridcontPersonel.DataSource = personelDal.PersonelListele(context);
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;

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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    
                        //string secilen = gridviewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
                        personelDal.Delete(context, c => c.PersonelKodu == gridviewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString());
                        personelDal.Save(context);
                        Listele();
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Silme İşlemi Gerçekleştirilemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem form = new FrmPersonelIslem(new SarpTicariOtomasyon_Entities.Tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            _secilen = gridviewPersonel.GetFocusedRowCellValue(colPersonelKodu).ToString();
            FrmPersonelIslem form = new FrmPersonelIslem(personelDal.GetByFilter(context, c => c.PersonelKodu == _secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }
    }
}
