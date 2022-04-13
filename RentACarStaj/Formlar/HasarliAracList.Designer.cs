
namespace RentACarStaj.Formlar
{
    partial class HasarliAracList
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.LblPlaka = new DevExpress.XtraEditors.LabelControl();
            this.LblModel = new DevExpress.XtraEditors.LabelControl();
            this.LblMarka = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            this.gridControl1.Size = new System.Drawing.Size(873, 562);
            this.gridControl1.TabIndex = 1;
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
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.LblPlaka);
            this.groupControl1.Controls.Add(this.LblModel);
            this.groupControl1.Controls.Add(this.LblMarka);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(891, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(281, 138);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Araç Bilgileri";
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
            // LblPlaka
            // 
            this.LblPlaka.Location = new System.Drawing.Point(151, 111);
            this.LblPlaka.Name = "LblPlaka";
            this.LblPlaka.Size = new System.Drawing.Size(4, 13);
            this.LblPlaka.TabIndex = 17;
            this.LblPlaka.Text = "-";
            // 
            // LblModel
            // 
            this.LblModel.Location = new System.Drawing.Point(151, 85);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(4, 13);
            this.LblModel.TabIndex = 16;
            this.LblModel.Text = "-";
            // 
            // LblMarka
            // 
            this.LblMarka.Location = new System.Drawing.Point(151, 59);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(4, 13);
            this.LblMarka.TabIndex = 15;
            this.LblMarka.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(88, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Marka:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Model:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(89, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Pkaka:";
            // 
            // HasarliAracList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "HasarliAracList";
            this.Text = "Hasarlı Araç Listesi";
            this.Load += new System.EventHandler(this.HasarliAracList_Load);
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
        private DevExpress.XtraEditors.LabelControl LblPlaka;
        private DevExpress.XtraEditors.LabelControl LblModel;
        private DevExpress.XtraEditors.LabelControl LblMarka;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}