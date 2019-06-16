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
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_Entities.Data_Access;

namespace SarpTicariOtomasyon_BackOffice.Tanımlar
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        TanimDAL tanimDal = new TanimDAL();
        private TanimTuru _tanimTuru;
        public  Tanim _entity;
        public bool  secildi=false;

        public FrmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;
           
        }

        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4
        }

        private void FrmTanim_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            gridcontTanim.DataSource = tanimDal.GetAll(context,c=>c.Turu==_tanimTuru.ToString());
        }

        void KayitAc()
        {
            BtnSec.Enabled = false;
            BtnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnVazgeç.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;
            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        void KayitKapat()
        {
            BtnSec.Enabled = true;
            BtnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnVazgeç.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           _entity = new Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {           
            int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
                    tanimDal.Delete(context, c => c.Id == secilen);
                    tanimDal.Save(context);
                    Listele();
                   
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hatalı İşlem.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimTuru.ToString();

            if (tanimDal.AddOrUpdate(context, _entity))
            {                
                tanimDal.Save(context);
                KayitKapat();
                Listele();
            }
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridTanim.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            secildi = true;
            this.Close();
        }
    }
}