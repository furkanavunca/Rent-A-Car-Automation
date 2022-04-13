
namespace RentACarStaj.Formlar
{
    partial class PersonelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LblDurum = new DevExpress.XtraEditors.LabelControl();
            this.LblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.LblYetki = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.LblMail = new DevExpress.XtraEditors.LabelControl();
            this.LblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.LblAd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnPersonelRemove = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPersonelGeriAl = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(826, 562);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.LblCinsiyet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.LblDurum);
            this.groupControl1.Controls.Add(this.LblTelefon);
            this.groupControl1.Controls.Add(this.LblYetki);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.LblMail);
            this.groupControl1.Controls.Add(this.LblSoyad);
            this.groupControl1.Controls.Add(this.LblAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(844, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 245);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Personel Bilgileri";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.Location = new System.Drawing.Point(151, 189);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(4, 13);
            this.LblCinsiyet.TabIndex = 31;
            this.LblCinsiyet.Text = "-";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(80, 189);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Cinsiyet:";
            // 
            // LblDurum
            // 
            this.LblDurum.Location = new System.Drawing.Point(151, 217);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(4, 13);
            this.LblDurum.TabIndex = 29;
            this.LblDurum.Text = "-";
            // 
            // LblTelefon
            // 
            this.LblTelefon.Location = new System.Drawing.Point(151, 137);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(4, 13);
            this.LblTelefon.TabIndex = 28;
            this.LblTelefon.Text = "-";
            // 
            // LblYetki
            // 
            this.LblYetki.Location = new System.Drawing.Point(151, 163);
            this.LblYetki.Name = "LblYetki";
            this.LblYetki.Size = new System.Drawing.Size(4, 13);
            this.LblYetki.TabIndex = 27;
            this.LblYetki.Text = "-";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(81, 217);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Durumu:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(82, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Telefon:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(95, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Yetki:";
            // 
            // LblID
            // 
            this.LblID.Location = new System.Drawing.Point(151, 33);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(4, 13);
            this.LblID.TabIndex = 23;
            this.LblID.Text = "-";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(107, 33);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(15, 13);
            this.labelControl14.TabIndex = 22;
            this.labelControl14.Text = "ID:";
            // 
            // LblMail
            // 
            this.LblMail.Location = new System.Drawing.Point(151, 111);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(4, 13);
            this.LblMail.TabIndex = 17;
            this.LblMail.Text = "-";
            // 
            // LblSoyad
            // 
            this.LblSoyad.Location = new System.Drawing.Point(151, 85);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(4, 13);
            this.LblSoyad.TabIndex = 16;
            this.LblSoyad.Text = "-";
            // 
            // LblAd
            // 
            this.LblAd.Location = new System.Drawing.Point(151, 59);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(4, 13);
            this.LblAd.TabIndex = 15;
            this.LblAd.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(105, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(88, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Soyad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(100, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mail:";
            // 
            // BtnPersonelRemove
            // 
            this.BtnPersonelRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonelRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelRemove.ImageOptions.Image")));
            this.BtnPersonelRemove.Location = new System.Drawing.Point(844, 263);
            this.BtnPersonelRemove.Name = "BtnPersonelRemove";
            this.BtnPersonelRemove.Size = new System.Drawing.Size(328, 43);
            this.BtnPersonelRemove.TabIndex = 18;
            this.BtnPersonelRemove.Text = "Personeli İşten Çıkart";
            this.BtnPersonelRemove.Click += new System.EventHandler(this.BtnPersonelRemove_Click);
            // 
            // BtnPersonelGeriAl
            // 
            this.BtnPersonelGeriAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonelGeriAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnPersonelGeriAl.Location = new System.Drawing.Point(844, 312);
            this.BtnPersonelGeriAl.Name = "BtnPersonelGeriAl";
            this.BtnPersonelGeriAl.Size = new System.Drawing.Size(328, 43);
            this.BtnPersonelGeriAl.TabIndex = 19;
            this.BtnPersonelGeriAl.Text = "Personeli İşe Al";
            this.BtnPersonelGeriAl.Click += new System.EventHandler(this.BtnPersonelGeriAl_Click);
            // 
            // PersonelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.BtnPersonelGeriAl);
            this.Controls.Add(this.BtnPersonelRemove);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PersonelList";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LblID;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl LblMail;
        private DevExpress.XtraEditors.LabelControl LblSoyad;
        private DevExpress.XtraEditors.LabelControl LblAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LblDurum;
        private DevExpress.XtraEditors.LabelControl LblTelefon;
        private DevExpress.XtraEditors.LabelControl LblYetki;
        private DevExpress.XtraEditors.LabelControl LblCinsiyet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelRemove;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelGeriAl;
    }
}