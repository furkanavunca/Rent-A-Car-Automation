using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarStaj.Formlar;
using RentACarStaj.Entity;

namespace RentACarStaj.Formlar
{
    public partial class KiralamaLog : Form
    {
        public KiralamaLog()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //gridcontrole veri tabanından bilgilerin çekilmesi
        void KiralikAracListele()
        {
            var liste = (from x in db.TblAracAlimLog
                         select new
                         {
                             x.ID,
                             Marka = x.TblAraclar.Marka,
                             Model = x.TblAraclar.Model,
                             Plaka = x.TblAraclar.Plaka,
                             TeslimEden = x.TblPersonel.Ad,
                             TeslimAlan = x.TblPersonel.Ad,
                             x.AlanAd,
                             x.AlanSoyad,
                             x.AlanTelefon,
                             Ehliyet = x.TblEhliyetTipleri.EhliyetTipi,
                             x.AlimTarihi,
                             x.TeslimTarihi,
                             Durum = x.TblDurum.Durum,
                             Ucret = x.TblAraclar.Ucret,
                             x.KiralamaUcreti
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
        }

        private void KiralamaLog_Load(object sender, EventArgs e)
        {
            KiralikAracListele();
        }

        //Gridcontrolde seçilen satırın labellara aktarımı
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            LblMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            LblModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
            LblPlaka.Text = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            LblTeslimAlan.Text = gridView1.GetFocusedRowCellValue("TeslimAlan").ToString();
            LblTeslimEden.Text = gridView1.GetFocusedRowCellValue("TeslimEden").ToString();
            LblAlimTarihi.Text = gridView1.GetFocusedRowCellValue("AlimTarihi").ToString();
            LblTeslimTarihi.Text = gridView1.GetFocusedRowCellValue("TeslimTarihi").ToString();
            LblAd.Text = gridView1.GetFocusedRowCellValue("AlanAd").ToString();
            LblSoyad.Text = gridView1.GetFocusedRowCellValue("AlanSoyad").ToString();
            Lbltel.Text = gridView1.GetFocusedRowCellValue("AlanTelefon").ToString();
            LblEhliyet.Text = gridView1.GetFocusedRowCellValue("Ehliyet").ToString();
            LblDurum.Text = gridView1.GetFocusedRowCellValue("Durum").ToString();
            LblTutar.Text = gridView1.GetFocusedRowCellValue("KiralamaUcreti").ToString();
        }
    }
}
