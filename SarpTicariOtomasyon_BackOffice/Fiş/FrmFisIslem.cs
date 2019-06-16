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
using System.Data.Entity;
using SarpTicariOtomasyon_Entities.Tables;
using SarpTicariOtomasyon_BackOffice.Stok;
using SarpTicariOtomasyon_BackOffice.Cari;
using SarpTicariOtomasyon_BackOffice.Depo;
using SarpTicariOtomasyon_BackOffice.Kasa;

namespace SarpTicariOtomasyon_BackOffice.Fiş
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        SarpTicariOtomasyonContext context = new SarpTicariOtomasyonContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        CariDAL cariDal = new CariDAL();
        Fis _fisEntity = new Fis();
        CariBakiye entityBakiye=new CariBakiye();
        

        public FrmFisIslem(string fisKodu=null)
        {
            try
            {
                if (fisKodu != null)
                {
                    _fisEntity = context.Fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                    context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                    context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                    entityBakiye = this.cariDal.CariBakiyesi(context, _fisEntity.CariKodu);

                    lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                    lblBorc.Text = entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
                }
                InitializeComponent();
                txtFisKodu.DataBindings.Add("Text", _fisEntity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
                txtFisTürü.DataBindings.Add("Text", _fisEntity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
                txtTarih.DataBindings.Add("EditValue", _fisEntity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
                txtbelgeNo.DataBindings.Add("Text", _fisEntity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
                txtAciklama.DataBindings.Add("Text", _fisEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
                lblCariKodu.DataBindings.Add("Text", _fisEntity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
                lblcariAdi.DataBindings.Add("Text", _fisEntity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
                txtfaturaUnvani.DataBindings.Add("Text", _fisEntity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
                txtIl.DataBindings.Add("Text", _fisEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
                txtIlce.DataBindings.Add("Text", _fisEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
                txtSemt.DataBindings.Add("Text", _fisEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
                txtAdres.DataBindings.Add("Text", _fisEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
                txtvergiDairesi.DataBindings.Add("Text", _fisEntity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
                txtvergiNo.DataBindings.Add("Text", _fisEntity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);

                gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
                gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
                Toplamlar();
                OdenenTutarGuncelle();

                //otomatik butan ekleme özelliği
                foreach (var item in context.OdemeTurleri.ToList())
                {
                    var buton = new SimpleButton
                    {
                        Name = item.OdemeTuruKodu,
                        Text = item.OdemeTuruAdi,
                        Height = 40,
                        Width = 100
                    };
                    buton.Click += OdemeEkle_Click;
                    flowOdemeTurleri.Controls.Add(buton);
                }
            }
            catch (Exception)
            {

               
            }
            
        }

        private void OdemeEkle_Click(object sender,EventArgs e)
        {
            var buton = (sender as SimpleButton);
            KasaHareket entityKasaHareket = new KasaHareket
            {
                OdemeTuruKodu=buton.Name,
                OdemeTuruAdi=buton.Text,
                Tutar=txtodenmesiGrekenTutar.Value

            };
            if (txtodenmesiGrekenTutar.Value<=0)
            {
                MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                OdenenTutarGuncelle();
            }
            
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            txtodemeTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtodenmesiGrekenTutar.Value = txtToplam.Value - txtodemeTutar.Value;
        }

        private void FrmFisIslem_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private StokHareket StokSec(SarpTicariOtomasyon_Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket
            {
                StokKodu = entity.StokKodu,
            StokAdi = entity.StokAdi,
            Barkod = entity.Barkod,
            BarkodTuru = entity.BarkodTuru,
            BirimFiyati = txtFisTürü.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1,
            Birimi = entity.Birimi,
            Miktar = txtMiktar.Value,
            Kdv = entity.SatisKdv,
            IndirimOrani = 0,
};
            return stokHareket;
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
            
        }

        private void TxtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SarpTicariOtomasyon_Entities.Tables.Stok entity;
                    entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                    if (entity != null)
                    {
                        stokHareketDal.AddOrUpdate(context, StokSec(entity));
                        Toplamlar();
                    }
                    else
                    {
                        MessageBox.Show("Aradığınız barkod numarasıürünler arasında bulunamadı.");
                    }

                    txtBarkod.Text = null;


                }
            }
            catch (Exception)
            {


            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtncariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                SarpTicariOtomasyon_Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = this.cariDal.CariBakiyesi(context, entity.CariKodu);

                lblCariKodu.Text = entity.CariKodu;
                lblcariAdi.Text= entity.CariAdi;
                txtfaturaUnvani.Text= entity.FaturaUnvani;
                txtvergiNo.Text= entity.VergiNo;
                txtvergiDairesi.Text= entity.VergiDairesi;
                txtAdres.Text= entity.Adres;
                txtCepTelefonu.Text= entity.CepTelefonu;
                txtIl.Text= entity.Il;
                txtIlce.Text= entity.Ilce;
                txtSemt.Text= entity.Semt;
                lblAlacak.Text =entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");

            }
        }

        private void BtnCariTemizle_Click(object sender, EventArgs e)
        {
            lblCariKodu.Text = "";
            lblcariAdi.Text ="";
            txtfaturaUnvani.Text ="";
            txtvergiNo.Text = "";
            txtvergiDairesi.Text = "";
            txtAdres.Text = "";
            txtCepTelefonu.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtSemt.Text = "";
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }

        private void GridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
                Toplamlar();
           
           
        }

        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            txtiskontoTutar.Value=Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue)/ 100 * txtiskontoOran.Value;
            txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue)- txtiskontoTutar.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtindirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);
            txtodenmesiGrekenTutar.Value = txtToplam.Value - txtodemeTutar.Value;
        }

        

        private void TxtiskontoOran_Validated(object sender, EventArgs e)
        {

            Toplamlar();
        }

        private void RepodepoAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmDepoSec form = new FrmDepoSec(gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridStokHareket.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);
            }

        }

        private void RepobirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();

            SarpTicariOtomasyon_Entities.Tables.Stok FiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = txtFisTürü.Text == "Alış Faturası" ? FiyatEntity.AlisFiyati1 ?? 0 : FiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTürü.Text == "Alış Faturası" ? FiyatEntity.AlisFiyati2 ?? 0 : FiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTürü.Text == "Alış Faturası" ? FiyatEntity.AlisFiyati3 ?? 0 : FiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati,Convert.ToDecimal(e.Item.Tag));
        }

        private void ReposeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri)
            {
                kilitli = false
            };
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void RepoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    gridStokHareket.DeleteSelectedRows();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hatalı İşlem.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void RepoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridKasaHareket.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void RepoKHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    gridKasaHareket.DeleteSelectedRows();
                    OdenenTutarGuncelle();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Hatalı İşlem.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void BtnislemKaydet_Click(object sender, EventArgs e)
        {
            int stokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int kasaHata= context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();

            if (stokHata==0&&kasaHata==0)
            {
                foreach (var stokVeri in context.StokHareketleri.Local.ToList())
                {
                    stokVeri.Tarih = stokVeri.Tarih == null ? Convert.ToDateTime(txtTarih.DateTime) : Convert.ToDateTime(stokVeri.Tarih);
                    stokVeri.FisKodu = txtFisKodu.Text;
                    stokVeri.Hareket = _fisEntity.FisTuru == "Alış Faturası" ? "Stok Giriş" : "Stok Çıkış";
                }

                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null ? Convert.ToDateTime(txtTarih.DateTime) : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = txtFisKodu.Text;
                    kasaVeri.Hareket = _fisEntity.FisTuru == "Alış Faturası" ? "Kasa Giriş" : "Kasa Çıkış";
                    kasaVeri.CariKodu = lblCariKodu.Text;
                    kasaVeri.CariAdi = lblcariAdi.Text;
                }
                _fisEntity.ToplamTutar = txtToplam.Value;
                _fisEntity.IskontoOrani = txtiskontoOran.Value;
                _fisEntity.IskontoTutar = txtiskontoTutar.Value;
                fisDal.AddOrUpdate(context, _fisEntity);
                context.SaveChanges();
                MessageBox.Show("İşlem Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri Girişi Yapılmadan Kaydetme İşlemi Yapılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        private void TxtTarih_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToLongTimeString();
        }

        private void GroupControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBarkod.Text = "";
        }

        private void GridContStokHareket_MouseClick(object sender, MouseEventArgs e)
        {
            txtBarkod.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //txtTarih.Text = DateTime.Now.ToString();
            txtTarih.Text = DateTime.Now.ToLongTimeString();

        }
    }
}