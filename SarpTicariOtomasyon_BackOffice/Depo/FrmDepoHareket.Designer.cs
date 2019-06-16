namespace SarpTicariOtomasyon_BackOffice.Depo
{
    partial class FrmDepoHareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoHareket));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridcontHareket = new DevExpress.XtraGrid.GridControl();
            this.stokHareketBindingSource = new System.Windows.Forms.BindingSource();
            this.gridHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coolSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontDepoStok = new DevExpress.XtraGrid.GridControl();
            this.gridDepoStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepoBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoUrünAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridcontIstatistik = new DevExpress.XtraGrid.GridControl();
            this.gridIstatistik = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBilgi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKayitSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridcontHareket);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblBaslik);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1186, 573);
            this.splitContainerControl1.SplitterPosition = 382;
            this.splitContainerControl1.TabIndex = 8;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridcontHareket
            // 
            this.gridcontHareket.DataSource = this.stokHareketBindingSource;
            this.gridcontHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontHareket.Location = new System.Drawing.Point(0, 55);
            this.gridcontHareket.MainView = this.gridHareket;
            this.gridcontHareket.Name = "gridcontHareket";
            this.gridcontHareket.Size = new System.Drawing.Size(1186, 327);
            this.gridcontHareket.TabIndex = 0;
            this.gridcontHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHareket});
            // 
            // stokHareketBindingSource
            // 
            this.stokHareketBindingSource.DataSource = typeof(SarpTicariOtomasyon_Entities.Tables.StokHareket);
            // 
            // gridHareket
            // 
            this.gridHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colStokKodu,
            this.colStokAdi,
            this.colBarkodTuru,
            this.colBarkod,
            this.colBirimi,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colIndirimTutari,
            this.colToplamTutar,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colSeriNo,
            this.colTarih,
            this.coolSaat,
            this.colAciklama});
            this.gridHareket.GridControl = this.gridcontHareket;
            this.gridHareket.Name = "gridHareket";
            this.gridHareket.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GridHareket_RowCellStyle);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 62;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 1;
            this.colHareket.Width = 111;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            // 
            // colBarkodTuru
            // 
            this.colBarkodTuru.Caption = "Barkod Türü";
            this.colBarkodTuru.FieldName = "BarkodTuru";
            this.colBarkodTuru.Name = "colBarkodTuru";
            this.colBarkodTuru.OptionsColumn.AllowEdit = false;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 2;
            this.colBirimi.Width = 84;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 7;
            this.colMiktar.Width = 53;
            // 
            // colKdv
            // 
            this.colKdv.Caption = "KDV%";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 6;
            this.colKdv.Width = 54;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 8;
            this.colBirimFiyati.Width = 88;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd.Oranı (%)";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 9;
            this.colIndirimOrani.Width = 88;
            // 
            // colIndirimTutari
            // 
            this.colIndirimTutari.Caption = "İnd.Tutarı";
            this.colIndirimTutari.DisplayFormat.FormatString = "C";
            this.colIndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutari.FieldName = "IndirimTutari";
            this.colIndirimTutari.Name = "colIndirimTutari";
            this.colIndirimTutari.OptionsColumn.AllowEdit = false;
            this.colIndirimTutari.Visible = true;
            this.colIndirimTutari.VisibleIndex = 10;
            this.colIndirimTutari.Width = 82;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            this.colToplamTutar.Width = 95;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.Caption = "Depo Kodu";
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.OptionsColumn.AllowEdit = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih ";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            this.colTarih.Width = 74;
            // 
            // coolSaat
            // 
            this.coolSaat.Caption = "Saat";
            this.coolSaat.DisplayFormat.FormatString = "t";
            this.coolSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coolSaat.FieldName = "Tarih";
            this.coolSaat.Name = "coolSaat";
            this.coolSaat.OptionsColumn.AllowEdit = false;
            this.coolSaat.Visible = true;
            this.coolSaat.VisibleIndex = 4;
            this.coolSaat.Width = 46;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açlama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 348;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1186, 55);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Depo Hareketleri";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1186, 186);
            this.splitContainerControl2.SplitterPosition = 589;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridcontDepoStok);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(589, 186);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Depodaki Stok Miktarı";
            // 
            // gridcontDepoStok
            // 
            this.gridcontDepoStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontDepoStok.Location = new System.Drawing.Point(2, 20);
            this.gridcontDepoStok.MainView = this.gridDepoStok;
            this.gridcontDepoStok.Name = "gridcontDepoStok";
            this.gridcontDepoStok.Size = new System.Drawing.Size(585, 164);
            this.gridcontDepoStok.TabIndex = 3;
            this.gridcontDepoStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDepoStok});
            // 
            // gridDepoStok
            // 
            this.gridDepoStok.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gridDepoStok.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridDepoStok.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridDepoStok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDepoBarkod,
            this.colDepoUrünAdi,
            this.colStokGiris,
            this.colStokCikis,
            this.colDepoMevcutStok});
            this.gridDepoStok.GridControl = this.gridcontDepoStok;
            this.gridDepoStok.Name = "gridDepoStok";
            this.gridDepoStok.OptionsView.ShowGroupPanel = false;
            // 
            // colDepoBarkod
            // 
            this.colDepoBarkod.Caption = "Barkod";
            this.colDepoBarkod.FieldName = "Barkod";
            this.colDepoBarkod.Name = "colDepoBarkod";
            this.colDepoBarkod.OptionsColumn.AllowEdit = false;
            this.colDepoBarkod.Visible = true;
            this.colDepoBarkod.VisibleIndex = 0;
            this.colDepoBarkod.Width = 112;
            // 
            // colDepoUrünAdi
            // 
            this.colDepoUrünAdi.Caption = "Ürün Adı";
            this.colDepoUrünAdi.FieldName = "StokAdi";
            this.colDepoUrünAdi.Name = "colDepoUrünAdi";
            this.colDepoUrünAdi.OptionsColumn.AllowEdit = false;
            this.colDepoUrünAdi.Visible = true;
            this.colDepoUrünAdi.VisibleIndex = 1;
            this.colDepoUrünAdi.Width = 316;
            // 
            // colStokGiris
            // 
            this.colStokGiris.Caption = "Stok Giriş";
            this.colStokGiris.FieldName = "StokGiris";
            this.colStokGiris.Name = "colStokGiris";
            this.colStokGiris.Visible = true;
            this.colStokGiris.VisibleIndex = 2;
            // 
            // colStokCikis
            // 
            this.colStokCikis.Caption = "Stok Çıkış";
            this.colStokCikis.FieldName = "StokCikis";
            this.colStokCikis.Name = "colStokCikis";
            this.colStokCikis.Visible = true;
            this.colStokCikis.VisibleIndex = 3;
            // 
            // colDepoMevcutStok
            // 
            this.colDepoMevcutStok.Caption = "Mevcut Stok";
            this.colDepoMevcutStok.DisplayFormat.FormatString = "C2";
            this.colDepoMevcutStok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDepoMevcutStok.FieldName = "MevcutStok";
            this.colDepoMevcutStok.Name = "colDepoMevcutStok";
            this.colDepoMevcutStok.OptionsColumn.AllowEdit = false;
            this.colDepoMevcutStok.Visible = true;
            this.colDepoMevcutStok.VisibleIndex = 4;
            this.colDepoMevcutStok.Width = 141;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridcontIstatistik);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(592, 186);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Depo İstatistikleri";
            // 
            // gridcontIstatistik
            // 
            this.gridcontIstatistik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontIstatistik.Location = new System.Drawing.Point(2, 20);
            this.gridcontIstatistik.MainView = this.gridIstatistik;
            this.gridcontIstatistik.Name = "gridcontIstatistik";
            this.gridcontIstatistik.Size = new System.Drawing.Size(588, 164);
            this.gridcontIstatistik.TabIndex = 2;
            this.gridcontIstatistik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIstatistik});
            // 
            // gridIstatistik
            // 
            this.gridIstatistik.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gridIstatistik.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridIstatistik.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridIstatistik.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBilgi,
            this.colDepoKayitSayisi,
            this.colDepoToplam});
            this.gridIstatistik.GridControl = this.gridcontIstatistik;
            this.gridIstatistik.Name = "gridIstatistik";
            this.gridIstatistik.OptionsView.ShowGroupPanel = false;
            // 
            // colBilgi
            // 
            this.colBilgi.Caption = "Bilgi";
            this.colBilgi.FieldName = "Bilgi";
            this.colBilgi.Name = "colBilgi";
            this.colBilgi.OptionsColumn.AllowEdit = false;
            this.colBilgi.Visible = true;
            this.colBilgi.VisibleIndex = 0;
            this.colBilgi.Width = 267;
            // 
            // colDepoKayitSayisi
            // 
            this.colDepoKayitSayisi.Caption = "Kayıt Sayısı";
            this.colDepoKayitSayisi.FieldName = "KayitSayisi";
            this.colDepoKayitSayisi.Name = "colDepoKayitSayisi";
            this.colDepoKayitSayisi.OptionsColumn.AllowEdit = false;
            this.colDepoKayitSayisi.Visible = true;
            this.colDepoKayitSayisi.VisibleIndex = 1;
            this.colDepoKayitSayisi.Width = 106;
            // 
            // colDepoToplam
            // 
            this.colDepoToplam.Caption = "Toplam";
            this.colDepoToplam.FieldName = "Toplam";
            this.colDepoToplam.Name = "colDepoToplam";
            this.colDepoToplam.Visible = true;
            this.colDepoToplam.VisibleIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1090, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(106, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 40);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 1;
            this.BtnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(5, 23);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(95, 40);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.BtnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 573);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1186, 68);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // FrmDepoHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 641);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmDepoHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Hareketleri";
            this.Load += new System.EventHandler(this.FrmDepoHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokHareketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepoStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstatistik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridcontHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHareket;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridcontDepoStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDepoStok;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoUrünAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoMevcutStok;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridcontIstatistik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIstatistik;
        private DevExpress.XtraGrid.Columns.GridColumn colBilgi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKayitSayisi;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private System.Windows.Forms.BindingSource stokHareketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn coolSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colStokGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colStokCikis;
    }
}