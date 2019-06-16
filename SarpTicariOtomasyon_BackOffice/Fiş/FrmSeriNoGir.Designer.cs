namespace SarpTicariOtomasyon_BackOffice.Fiş
{
    partial class FrmSeriNoGir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeriNoGir));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpbilgi = new DevExpress.XtraEditors.GroupControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVazgeç = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listseriNo = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpbilgi)).BeginInit();
            this.grpbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listseriNo)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(505, 55);
            this.lblBaslik.TabIndex = 13;
            this.lblBaslik.Text = "Seri No Bilgilei";
            // 
            // grpbilgi
            // 
            this.grpbilgi.Controls.Add(this.listseriNo);
            this.grpbilgi.Controls.Add(this.txtSeriNo);
            this.grpbilgi.Controls.Add(this.labelControl4);
            this.grpbilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbilgi.Location = new System.Drawing.Point(0, 55);
            this.grpbilgi.Name = "grpbilgi";
            this.grpbilgi.Size = new System.Drawing.Size(505, 276);
            this.grpbilgi.TabIndex = 14;
            this.grpbilgi.Text = "Seri No Bilgileri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.BtnVazgeç);
            this.grpMenu.Controls.Add(this.BtnKaydet);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnYeni);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 332);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(505, 68);
            this.grpMenu.TabIndex = 15;
            this.grpMenu.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(410, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnVazgeç
            // 
            this.BtnVazgeç.Enabled = false;
            this.BtnVazgeç.ImageOptions.ImageIndex = 3;
            this.BtnVazgeç.ImageOptions.ImageList = this.ımageList1;
            this.BtnVazgeç.Location = new System.Drawing.Point(309, 23);
            this.BtnVazgeç.Name = "BtnVazgeç";
            this.BtnVazgeç.Size = new System.Drawing.Size(95, 40);
            this.BtnVazgeç.TabIndex = 0;
            this.BtnVazgeç.Text = "Vazgeç";
            this.BtnVazgeç.Click += new System.EventHandler(this.BtnVazgeç_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.ImageOptions.ImageIndex = 2;
            this.BtnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(208, 23);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(95, 40);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 1;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(112, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 40);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageOptions.ImageIndex = 0;
            this.btnYeni.ImageOptions.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(5, 23);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(102, 40);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.BtnYeni_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Enabled = false;
            this.txtSeriNo.Location = new System.Drawing.Point(117, 27);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(377, 20);
            this.txtSeriNo.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 24);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Seri No :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            // 
            // listseriNo
            // 
            this.listseriNo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listseriNo.Appearance.Options.UseFont = true;
            this.listseriNo.Location = new System.Drawing.Point(5, 53);
            this.listseriNo.Name = "listseriNo";
            this.listseriNo.Size = new System.Drawing.Size(489, 218);
            this.listseriNo.TabIndex = 34;
            // 
            // FrmSeriNoGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 400);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpbilgi);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeriNoGir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seri No Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeriNoGir_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeriNoGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpbilgi)).EndInit();
            this.grpbilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listseriNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpbilgi;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnVazgeç;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.ListBoxControl listseriNo;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ImageList ımageList1;
    }
}