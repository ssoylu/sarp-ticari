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

namespace SarpTicariOtomasyon_BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        DepoDAL depoDal = new DepoDAL();
        public SarpTicariOtomasyon_Entities.Tables.Depo entity = new SarpTicariOtomasyon_Entities.Tables.Depo();
        private string _stokKodu;
        public bool secildi = false;

        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridcontDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridDepolar.SelectedRowsCount!=0)
            {
                string depoKodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }
          
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}