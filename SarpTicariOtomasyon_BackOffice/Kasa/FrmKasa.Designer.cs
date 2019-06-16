namespace SarpTicariOtomasyon_BackOffice.Kasa
{
    partial class FrmKasa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnStokHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridcontKasalar = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAciklama = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAciklama = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaGiris = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaCikis = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBakiye = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colBakiye = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreiptal = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 1;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(102, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 40);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "folder_out.png");
            this.imgMenu.Images.SetKeyName(1, "KasaDuzenle.png");
            this.imgMenu.Images.SetKeyName(2, "KasaEkle.png");
            this.imgMenu.Images.SetKeyName(3, "KasaHareket.png");
            this.imgMenu.Images.SetKeyName(4, "KasaSil.png");
            this.imgMenu.Images.SetKeyName(5, "refresh.png");
            this.imgMenu.Images.SetKeyName(6, "view.png");
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnStokHareket);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.BtnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 653);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1370, 68);
            this.grpMenu.TabIndex = 7;
            this.grpMenu.Text = "Menü";
            // 
            // btnStokHareket
            // 
            this.btnStokHareket.ImageOptions.ImageIndex = 3;
            this.btnStokHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnStokHareket.Location = new System.Drawing.Point(305, 23);
            this.btnStokHareket.Name = "btnStokHareket";
            this.btnStokHareket.Size = new System.Drawing.Size(106, 40);
            this.btnStokHareket.TabIndex = 1;
            this.btnStokHareket.Text = "Kasa\r\nHareket\r\n";
            this.btnStokHareket.Click += new System.EventHandler(this.btnStokHareket_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 2;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(7, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1274, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 6;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(518, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 40);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 5;
            this.BtnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.BtnGuncelle.Location = new System.Drawing.Point(417, 23);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(95, 40);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 4;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(209, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 40);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.lblBaslik.Size = new System.Drawing.Size(1370, 55);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Kasalar";
            // 
            // gridcontKasalar
            // 
            this.gridcontKasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontKasalar.Location = new System.Drawing.Point(0, 0);
            this.gridcontKasalar.MainView = this.layoutView1;
            this.gridcontKasalar.Name = "gridcontKasalar";
            this.gridcontKasalar.Size = new System.Drawing.Size(1370, 528);
            this.gridcontKasalar.TabIndex = 0;
            this.gridcontKasalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.layoutView1.GridControl = this.gridcontKasalar;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 137;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(58, 20);
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.LayoutViewField = this.layoutViewField_colKasaKodu;
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.Width = 112;
            // 
            // layoutViewField_colKasaKodu
            // 
            this.layoutViewField_colKasaKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaKodu.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colKasaKodu.Name = "layoutViewField_colKasaKodu";
            this.layoutViewField_colKasaKodu.Size = new System.Drawing.Size(203, 48);
            this.layoutViewField_colKasaKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.LayoutViewField = this.layoutViewField_colKasaAdi;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.Width = 150;
            // 
            // layoutViewField_colKasaAdi
            // 
            this.layoutViewField_colKasaAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaAdi.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colKasaAdi.Name = "layoutViewField_colKasaAdi";
            this.layoutViewField_colKasaAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.LayoutViewField = this.layoutViewField_colYetkiliKodu;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.Width = 101;
            // 
            // layoutViewField_colYetkiliKodu
            // 
            this.layoutViewField_colYetkiliKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliKodu.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colYetkiliKodu.Name = "layoutViewField_colYetkiliKodu";
            this.layoutViewField_colYetkiliKodu.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.LayoutViewField = this.layoutViewField_colYetkiliAdi;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.Width = 153;
            // 
            // layoutViewField_colYetkiliAdi
            // 
            this.layoutViewField_colYetkiliAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliAdi.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colYetkiliAdi.Name = "layoutViewField_colYetkiliAdi";
            this.layoutViewField_colYetkiliAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.LayoutViewField = this.layoutViewField_colAciklama;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Width = 373;
            // 
            // layoutViewField_colAciklama
            // 
            this.layoutViewField_colAciklama.EditorPreferredWidth = 137;
            this.layoutViewField_colAciklama.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colAciklama.Name = "layoutViewField_colAciklama";
            this.layoutViewField_colAciklama.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colAciklama.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.LayoutViewField = this.layoutViewField_colKasaGiris;
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.Width = 151;
            // 
            // layoutViewField_colKasaGiris
            // 
            this.layoutViewField_colKasaGiris.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaGiris.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colKasaGiris.Name = "layoutViewField_colKasaGiris";
            this.layoutViewField_colKasaGiris.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaGiris.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.LayoutViewField = this.layoutViewField_colKasaCikis;
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.Width = 151;
            // 
            // layoutViewField_colKasaCikis
            // 
            this.layoutViewField_colKasaCikis.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaCikis.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colKasaCikis.Name = "layoutViewField_colKasaCikis";
            this.layoutViewField_colKasaCikis.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaCikis.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.LayoutViewField = this.layoutViewField_colBakiye;
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.Width = 161;
            // 
            // layoutViewField_colBakiye
            // 
            this.layoutViewField_colBakiye.EditorPreferredWidth = 137;
            this.layoutViewField_colBakiye.Location = new System.Drawing.Point(0, 192);
            this.layoutViewField_colBakiye.Name = "layoutViewField_colBakiye";
            this.layoutViewField_colBakiye.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colBakiye.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colKasaKodu,
            this.layoutViewField_colKasaAdi,
            this.layoutViewField_colYetkiliKodu,
            this.layoutViewField_colYetkiliAdi,
            this.layoutViewField_colAciklama,
            this.layoutViewField_colKasaGiris,
            this.layoutViewField_colKasaCikis,
            this.layoutViewField_colBakiye});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreiptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridcontKasalar);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1370, 598);
            this.splitContainerControl1.SplitterPosition = 65;
            this.splitContainerControl1.TabIndex = 8;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 1;
            this.btnFiltrele.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltrele.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1218, 25);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(41, 35);
            toolTipTitleItem1.Text = "Filtrele";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnFiltrele.SuperTip = superToolTip1;
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "funnel.png");
            this.ımageList1.Images.SetKeyName(2, "funnel_delete.png");
            // 
            // btnFiltreiptal
            // 
            this.btnFiltreiptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreiptal.ImageOptions.ImageIndex = 2;
            this.btnFiltreiptal.ImageOptions.ImageList = this.ımageList1;
            this.btnFiltreiptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreiptal.Location = new System.Drawing.Point(1265, 25);
            this.btnFiltreiptal.Name = "btnFiltreiptal";
            this.btnFiltreiptal.Size = new System.Drawing.Size(43, 35);
            toolTipTitleItem2.Text = "Filtre İptal";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnFiltreiptal.SuperTip = superToolTip2;
            this.btnFiltreiptal.TabIndex = 1;
            this.btnFiltreiptal.Click += new System.EventHandler(this.btnFiltreiptal_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 0;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1314, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(44, 35);
            toolTipTitleItem3.Text = "Filtreyi Kapat";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.simpleButton1.SuperTip = superToolTip3;
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.ShowGroupCommandsIcon = true;
            this.filterControl1.Size = new System.Drawing.Size(1370, 65);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridcontKasalar;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmKasa";
            this.Text = "Kasalar";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnStokHareket;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.GridControl gridcontKasalar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnFiltreiptal;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAciklama;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAciklama;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaGiris;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaGiris;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaCikis;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaCikis;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}