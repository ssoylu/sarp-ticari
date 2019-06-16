using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarpTicariOtomasyon_BackOffice.Personeller
{
    public partial class FrmPersonelIslem : Form
    {
        private SarpTicariOtomasyon_Entities.Tables.Personel _entity;
        private PersonelDAL personelDal = new PersonelDAL();
        private SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        public bool saved = false;

        public FrmPersonelIslem(SarpTicariOtomasyon_Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleCalisiyor.DataBindings.Add("EditValue", _entity, "Calisiyor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnvani.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTcNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbIseGirisTarihi.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null,"F");
            cmbIstenCikisTarihi.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi",false,DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAylıkMaasi.DataBindings.Add("EditValue", _entity, "AylikMaasi", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcPrimOrani.DataBindings.Add("EditValue", _entity, "PirimOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
           

        }

        private void GroupGenelBilgi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPersonelIslem_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnislemKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (personelDal.AddOrUpdate(context,_entity))
                {
                    saved = true;
                    personelDal.Save(context);
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kaydetme İşlemi Yapılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbIseGirisTarihi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cmbIseGirisTarihi.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cmbIseGirisTarihi.Text = DateTime.Now.ToString();
        }

        private void cmbIstenCikisTarihi_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmbIstenCikisTarihi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
