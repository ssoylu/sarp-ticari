using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Data_Access;
using SarpTicariOtomasyon_Entities.Tables;

namespace SarpTicariOtomasyon_BackOffice.Stok
{
    public partial class frmStokislem : Form
    {
        private SarpTicariOtomasyon_Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        public bool saved = false;

        public frmStokislem(SarpTicariOtomasyon_Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu",false,DataSourceUpdateMode.OnPropertyChanged);
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBarkodtürü.DataBindings.Add("Text", _entity, "BarkodTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBirimi.DataBindings.Add("Text", _entity, "Birimi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGarantisüresi.DataBindings.Add("Text", _entity, "GarantiSuresi", false, DataSourceUpdateMode.OnPropertyChanged);

            calcMaxstokmiktari.DataBindings.Add("Text", _entity, "MaxStokMiktari", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMaxstokmiktari.DataBindings[0].FormattingEnabled = true;
            calcMaxstokmiktari.DataBindings[0].FormatString = "N3";

            calcMinstokMiktari.DataBindings.Add("Text", _entity, "MinStokMiktari", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMinstokMiktari.DataBindings[0].FormattingEnabled = true;
            calcMinstokMiktari.DataBindings[0].FormatString = "N3";

            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokgrubu.DataBindings.Add("Text", _entity, "StokGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokaltgrub.DataBindings.Add("Text", _entity, "StokAltGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            btnModel.DataBindings.Add("Text", _entity, "Modeli", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelkod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelkod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelkod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelkod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);

            calcAlisfiyat1.DataBindings.Add("Text", _entity, "AlisFiyati1", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisfiyat1.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyat1.DataBindings[0].FormatString = "C2";

            calcAlisfiyat2.DataBindings.Add("Text", _entity, "AlisFiyati2", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisfiyat2.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyat2.DataBindings[0].FormatString = "C2";

            calcAlisfiyat3.DataBindings.Add("Text", _entity, "AlisFiyati3", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisfiyat3.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyat3.DataBindings[0].FormatString = "C2";


            calcAliskdv.DataBindings.Add("Text", _entity, "AlisKdv", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAliskdv.DataBindings[0].FormattingEnabled = true;
            calcAliskdv.DataBindings[0].FormatString = "'%'0'";

            calcSatiskdv.DataBindings.Add("Text", _entity, "SatisKdv", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatiskdv.DataBindings[0].FormattingEnabled = true;
            calcSatiskdv.DataBindings[0].FormatString = "'%'0'";

            calcSatisfiyat1.DataBindings.Add("Text", _entity, "SatisFiyati1", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisfiyat1.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyat1.DataBindings[0].FormatString = "C2";

            calcSatisfiyat2.DataBindings.Add("Text", _entity, "SatisFiyati2", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisfiyat2.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyat2.DataBindings[0].FormatString = "C2";

            calcSatisfiyat3.DataBindings.Add("Text", _entity, "SatisFiyati3", false, DataSourceUpdateMode.OnPropertyChanged);
            calcSatisfiyat3.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyat3.DataBindings[0].FormatString = "C2";

        }



        private void FrmStokislem_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDal.AddOrUpdate(context, _entity))
            {
                stokDal.Save(context);
                saved = true;
                this.Close();
            }          
          
            
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
