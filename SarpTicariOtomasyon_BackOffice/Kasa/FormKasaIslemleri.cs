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
    public partial class FormKasaIslemleri : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        public bool Kaydedildi = false;
        private SarpTicariOtomasyon_Entities.Tables.Kasa _entity;

        public FormKasaIslemleri(SarpTicariOtomasyon_Entities.Tables.Kasa entity)
        {
            InitializeComponent( );
            _entity = entity;
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FormKasaIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpdate(context,_entity))
            {
                kasaDal.Save(context);
                Kaydedildi = true;
                this.Close();
            }
        }
    }
}