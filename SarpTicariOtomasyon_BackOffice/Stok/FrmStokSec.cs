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

namespace SarpTicariOtomasyon_BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        public List<SarpTicariOtomasyon_Entities.Tables.Stok> secilen=new List<SarpTicariOtomasyon_Entities.Tables.Stok>();
        public bool secildi = false;
        
        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridconStoklar.DataSource = stokDal.GetAlljoin(context);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length!=0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokkodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Ürün Bulunamadı");
            }
            
        }
    }
}