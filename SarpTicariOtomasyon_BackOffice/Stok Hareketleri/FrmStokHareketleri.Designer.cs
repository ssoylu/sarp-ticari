namespace SarpTicariOtomasyon_BackOffice.Stok_Hareketleri
{
    partial class FrmStokHareketleri
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokHareketleri));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.gridcontStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodTürü = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoSeriNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colİndirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnStokHareket = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreiptal = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridcontStokHareket
            // 
            this.gridcontStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridcontStokHareket.MainView = this.gridStokHareket;
            this.gridcontStokHareket.Name = "gridcontStokHareket";
            this.gridcontStokHareket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoSeriNo});
            this.gridcontStokHareket.Size = new System.Drawing.Size(1370, 528);
            this.gridcontStokHareket.TabIndex = 0;
            this.gridcontStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gridStokHareket.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridStokHareket.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colBarkod,
            this.colBarkodTürü,
            this.colStokKodu,
            this.colStokAdi,
            this.colDepoKodu,
            this.colDepoAdi,
            this.colHareket,
            this.colBirimi,
            this.colTarih,
            this.colSaat,
            this.colAciklama,
            this.colSeriNo,
            this.colKdv,
            this.colMiktar,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colİndirimTutari,
            this.colKdvTutar,
            this.colToplamTutar});
            this.gridStokHareket.GridControl = this.gridcontStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 116;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 72;
            // 
            // colBarkodTürü
            // 
            this.colBarkodTürü.Caption = "Barkod Türü";
            this.colBarkodTürü.FieldName = "BarkodTuru";
            this.colBarkodTürü.Name = "colBarkodTürü";
            this.colBarkodTürü.OptionsColumn.AllowEdit = false;
            this.colBarkodTürü.Visible = true;
            this.colBarkodTürü.VisibleIndex = 2;
            this.colBarkodTürü.Width = 73;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 3;
            this.colStokKodu.Width = 62;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 4;
            this.colStokAdi.Width = 62;
            // 
            // colDepoKodu
            // 
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.OptionsColumn.AllowEdit = false;
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 5;
            this.colDepoKodu.Width = 62;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 6;
            this.colDepoAdi.Width = 62;
            // 
            // colHareket
            // 
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.Visible = true;
            this.colHareket.VisibleIndex = 7;
            this.colHareket.Width = 62;
            // 
            // colBirimi
            // 
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 8;
            this.colBirimi.Width = 62;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 9;
            this.colTarih.Width = 62;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 10;
            this.colSaat.Width = 62;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 11;
            this.colAciklama.Width = 62;
            // 
            // colSeriNo
            // 
            this.colSeriNo.Caption = "Seri No";
            this.colSeriNo.ColumnEdit = this.repoSeriNo;
            this.colSeriNo.FieldName = "SeriNo";
            this.colSeriNo.Name = "colSeriNo";
            this.colSeriNo.Visible = true;
            this.colSeriNo.VisibleIndex = 12;
            this.colSeriNo.Width = 63;
            // 
            // repoSeriNo
            // 
            this.repoSeriNo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repoSeriNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Seri No", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoSeriNo.Name = "repoSeriNo";
            this.repoSeriNo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoSeriNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepoSeriNo_ButtonClick);
            // 
            // colKdv
            // 
            this.colKdv.Caption = "KDV(%)";
            this.colKdv.DisplayFormat.FormatString = "\'%\'0";
            this.colKdv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            this.colKdv.Visible = true;
            this.colKdv.VisibleIndex = 13;
            this.colKdv.Width = 57;
            // 
            // colMiktar
            // 
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 14;
            this.colMiktar.Width = 49;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.DisplayFormat.FormatString = "C2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 15;
            this.colBirimFiyati.Width = 66;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.Caption = "İnd.Oranı(%)";
            this.colIndirimOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIndirimOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 16;
            this.colIndirimOrani.Width = 73;
            // 
            // colİndirimTutari
            // 
            this.colİndirimTutari.Caption = "İnd.Tutarı";
            this.colİndirimTutari.DisplayFormat.FormatString = "C2";
            this.colİndirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colİndirimTutari.FieldName = "IndirimTutari";
            this.colİndirimTutari.Name = "colİndirimTutari";
            this.colİndirimTutari.OptionsColumn.AllowEdit = false;
            this.colİndirimTutari.Visible = true;
            this.colİndirimTutari.VisibleIndex = 17;
            this.colİndirimTutari.Width = 80;
            // 
            // colKdvTutar
            // 
            this.colKdvTutar.Caption = "KDV Tutar";
            this.colKdvTutar.DisplayFormat.FormatString = "C2";
            this.colKdvTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKdvTutar.FieldName = "KdvTutari";
            this.colKdvTutar.Name = "colKdvTutar";
            this.colKdvTutar.OptionsColumn.AllowEdit = false;
            this.colKdvTutar.Visible = true;
            this.colKdvTutar.VisibleIndex = 18;
            this.colKdvTutar.Width = 64;
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
            this.colToplamTutar.VisibleIndex = 19;
            this.colToplamTutar.Width = 82;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnStokHareket);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.BtnGuncelle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 653);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1370, 68);
            this.grpMenu.TabIndex = 4;
            this.grpMenu.Text = "Menü";
            // 
            // btnStokHareket
            // 
            this.btnStokHareket.ImageOptions.ImageIndex = 6;
            this.btnStokHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnStokHareket.Location = new System.Drawing.Point(12, 23);
            this.btnStokHareket.Name = "btnStokHareket";
            this.btnStokHareket.Size = new System.Drawing.Size(106, 40);
            this.btnStokHareket.TabIndex = 1;
            this.btnStokHareket.Text = "Detayı Gör";
            this.btnStokHareket.Click += new System.EventHandler(this.BtnStokHareket_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "refresh.png");
            this.imgMenu.Images.SetKeyName(1, "view.png");
            this.imgMenu.Images.SetKeyName(2, "folder_out.png");
            this.imgMenu.Images.SetKeyName(3, "folder_out.png");
            this.imgMenu.Images.SetKeyName(4, "funnel.png");
            this.imgMenu.Images.SetKeyName(5, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(6, "note_information.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 2;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1274, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 1;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(225, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 40);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 0;
            this.BtnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.BtnGuncelle.Location = new System.Drawing.Point(124, 23);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(95, 40);
            this.BtnGuncelle.TabIndex = 0;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
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
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Stok Hareketleri";
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridcontStokHareket);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1370, 598);
            this.splitContainerControl1.SplitterPosition = 65;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.ImageOptions.ImageIndex = 4;
            this.btnFiltrele.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltrele.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltrele.Location = new System.Drawing.Point(1218, 25);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(41, 35);
            toolTipTitleItem1.Text = "Filtrele";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnFiltrele.SuperTip = superToolTip1;
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // btnFiltreiptal
            // 
            this.btnFiltreiptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreiptal.ImageOptions.ImageIndex = 5;
            this.btnFiltreiptal.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreiptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFiltreiptal.Location = new System.Drawing.Point(1265, 25);
            this.btnFiltreiptal.Name = "btnFiltreiptal";
            this.btnFiltreiptal.Size = new System.Drawing.Size(43, 35);
            toolTipTitleItem2.Text = "Filtre İptal";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnFiltreiptal.SuperTip = superToolTip2;
            this.btnFiltreiptal.TabIndex = 1;
            this.btnFiltreiptal.Click += new System.EventHandler(this.BtnFiltreiptal_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 3;
            this.simpleButton1.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1314, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(44, 35);
            toolTipTitleItem3.Text = "Filtreyi Kapat";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.simpleButton1.SuperTip = superToolTip3;
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.ShowGroupCommandsIcon = true;
            this.filterControl1.Size = new System.Drawing.Size(1370, 65);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridcontStokHareket;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmStokHareketleri";
            this.Text = "FrmStokHareketleri";
            this.Load += new System.EventHandler(this.FrmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSeriNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridcontStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnStokHareket;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.SimpleButton btnFiltreiptal;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colİndirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoSeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodTürü;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
    }
}