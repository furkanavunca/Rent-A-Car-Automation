using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RentACarStaj.Entity;
using RentACarStaj.Formlar;

namespace RentACarStaj.Formlar
{
    public partial class HasarliAracList : Form
    {
        public HasarliAracList()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();
        //hasarlı araçların listeklenmesi
        void HasarliAracListele()
        {
            var liste = (from x in db.TblHasarLog
                         select new
                         {
                             x.ID,
                             Marka = x.TblAraclar.Marka,
                             Model = x.TblAraclar.Model,
                             Plaka = x.TblAraclar.Plaka,
                             x.HasarAciklama,
                             Durum = x.TblDurum.Durum
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
        }

        private void HasarliAracList_Load(object sender, EventArgs e)
        {
            HasarliAracListele();
        }
        //gridcontrolde çekilen verilerin labellara aktarımı
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                LblMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                LblModel.Text= gridView1.GetFocusedRowCellValue("Model").ToString();
                LblPlaka.Text = gridView1.GetFocusedRowCellValue("Plaka").ToString(); 
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Gerekli Bilgiler Veri Tabanın Alınamadı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
