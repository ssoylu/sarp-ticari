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
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal = new KasaDAL();
        SarpTicariOtomasyonContext context =new  SarpTicariOtomasyonContext();
        public SarpTicariOtomasyon_Entities.Tables.Kasa entity=new SarpTicariOtomasyon_Entities.Tables.Kasa();
        public bool secildi = false;
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridcontSecim.DataSource = kasaDal.GetKasa(context);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridSecim.GetSelectedRows().Length!=0)
            {
                string kasakodu = gridSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasakodu);
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
