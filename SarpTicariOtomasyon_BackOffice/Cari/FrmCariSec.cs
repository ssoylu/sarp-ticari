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
using SarpTicariOtomasyon_Entities.Tables;

namespace SarpTicariOtomasyon_BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        public List<SarpTicariOtomasyon_Entities.Tables.Cari> secilen = new List<SarpTicariOtomasyon_Entities.Tables.Cari>();
        public bool secildi = false;

        public FrmCariSec(bool cokluSecim = false)
        {
           
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));
                    
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir Cari bulunamadı.");
            }
            
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}