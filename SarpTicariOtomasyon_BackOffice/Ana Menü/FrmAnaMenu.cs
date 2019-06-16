using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SarpTicariOtomasyon_BackOffice.Stok;
using SarpTicariOtomasyon_BackOffice.Cari;
using SarpTicariOtomasyon_BackOffice.Kasa;
using SarpTicariOtomasyon_BackOffice.Depo;
using SarpTicariOtomasyon_BackOffice.Fiş;
using SarpTicariOtomasyon_BackOffice.Tanımlar;
using SarpTicariOtomasyon_BackOffice.Ödeme_Türü;
using SarpTicariOtomasyon_Entities.Context;
using SarpTicariOtomasyon_Entities.Data_Access;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_BackOffice.Ana_Menü;
using SarpTicariOtomasyon_BackOffice.Stok_Hareketleri;
using SarpTicariOtomasyon_BackOffice.Kasa_Hareketleri;
using SarpTicariOtomasyon_BackOffice.Personeller;

namespace SarpTicariOtomasyon_BackOffice
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        CariDAL cariDAL = new CariDAL();
        public Form1()
        {
            InitializeComponent();
            using (var context=new SarpTicariOtomasyonContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FrmAnaMenüBilgi form = new FrmAnaMenüBilgi
            //{
            //    MdiParent = this
            //};
            //form.Show();

            //SarpTicariOtomasyon_Entities.Tables.Cari entity = new SarpTicariOtomasyon_Entities.Tables.Cari
            //{

            //};
            //cariDAL.AddOrUpdate(context, entity);
            //cariDAL.Save(context);
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStok form = new frmStok
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             FrmKasa form = new FrmKasa
             {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo form = new FrmDepo
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem()
            {
              
            };
            form.ShowDialog();


        }

        private void BarButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnaMenüBilgi form = new FrmAnaMenüBilgi
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri form = new FrmStokHareketleri
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri form = new FrmKasaHareketleri
            {
                MdiParent = this
            };
            form.Show();
        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel form = new FrmPersonel
            {
                MdiParent = this
            };
            form.Show();
        }

    }
}
