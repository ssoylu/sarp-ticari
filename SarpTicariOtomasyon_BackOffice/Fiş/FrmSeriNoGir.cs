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

namespace SarpTicariOtomasyon_BackOffice.Fiş
{
    public partial class FrmSeriNoGir : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public bool kilitli = true;

        public FrmSeriNoGir(string veri)
        {
            InitializeComponent();
            if (veri!=null)
            {
                string[] veriListesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)
                {
                    listseriNo.Items.Add(item);
                }
            }
            if (kilitli)
            {
                grpMenu.Enabled = false;
            }



        }

        void KayitAc()
        {
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnVazgeç.Enabled = true;
            txtSeriNo.Enabled = true;
            txtSeriNo.Focus();
        }

        void KayitKapat()
        {
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnVazgeç.Enabled = false;
            txtSeriNo.Enabled = false;
            
            txtSeriNo.Text = "";
        }

        private void FrmSeriNoGir_Load(object sender, EventArgs e)
        {

        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            listseriNo.Items.Remove(listseriNo.SelectedItem);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            listseriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNoGir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listseriNo.Items.Count!=0)
            {
                foreach (var item in listseriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }           

        }
    }
}