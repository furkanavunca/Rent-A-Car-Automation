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
using DevExpress.XtraEditors;
using RentACarStaj.Entity;

namespace RentACarStaj.Formlar
{
    public partial class AracKirala : Form
    {
        public AracKirala()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //Veri Tabanında bulundurulan araçların listendiği kısım
        void AracListele()
        {
            var degerler = from x in db.TblAraclar
                           select new
                           {
                               x.ID,
                               x.Marka,
                               x.Model,
                               x.Plaka,
                               x.SiradakiBakimTarihi,
                               x.SonBakimTarihi,
                               Durum = x.TblDurum.Durum,
                               x.Ucret
                           };
            gridControl1.DataSource = degerler.Where(x=>x.Durum=="Stokta").ToList();
        }
        //LookUpEdit 1 e ehliyet bilgilerinin çekildiği kısım
        void lookUpEhliyet()
        {
            var ehliyet = (from x in db.TblEhliyetTipleri
                           select new
                           {
                               x.ID,
                               x.EhliyetTipi
                           }).ToList();

            LookUpEhliyetTipi.Properties.ValueMember = "ID";
            LookUpEhliyetTipi.Properties.DisplayMember = "EhliyetTipi";
            LookUpEhliyetTipi.Properties.DataSource = ehliyet;
        }
        //LookUpEdit 2 ye personellerin isimlerinin çekildiği kısım
        void lookUpPersonel()
        {
            var personeller = (from x in db.TblPersonel
                               select new
                               {
                                   x.ID,
                                   x.Ad,
                                   x.Soyad,
                                   x.Durum,
                                   Yetki = x.TblYetki.Yetki
                               }).ToList();
            LookPersonel.Properties.ValueMember = "ID";
            LookPersonel.Properties.DisplayMember = "Ad";
            LookPersonel.Properties.DataSource = personeller.Where(x => x.Durum == true && (x.Yetki == "Yönetici" || x.Yetki == "Kiralama Personeli"));
        }
        private void AracKirala_Load(object sender, EventArgs e)
        {
            AracListele();
            lookUpEhliyet();
            lookUpPersonel();
        }

        //Gridcontrol objesinde seçilen satırın labellara aktarılması
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            LblMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
            LblModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
            LblPlaka.Text = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            LblSiradakiBakim.Text = gridView1.GetFocusedRowCellValue("SiradakiBakimTarihi").ToString();
            LblSonBakim.Text = gridView1.GetFocusedRowCellValue("SonBakimTarihi").ToString();
            LblUcret.Text = gridView1.GetFocusedRowCellValue("Ucret").ToString();
        }

        //Kiralanan aracın veri tabanına işlenmesi
        private void BtnAracKiralamaGerceklestir_Click(object sender, EventArgs e)
        {
            TblAracAlimLog log = new TblAracAlimLog();
            log.AracNo = Convert.ToInt32(LblID.Text);
            log.TeslimEden = int.Parse(LookPersonel.EditValue.ToString());
            log.TeslimAlan = 6;
            log.AlanAd = TxtAd.Text;
            log.AlanSoyad = TxtSoyad.Text;
            log.AlanTelefon = TxtTel.Text;
            log.Ehliyet = int.Parse(LookUpEhliyetTipi.EditValue.ToString());
            log.AlimTarihi = DateAlimTarihi.DateTime;
            log.Durum = 2;
            log.KiralamaUcreti = Convert.ToInt32(LblToplamUcret.Text);
            var aracno = db.TblAraclar.Find(Convert.ToInt32(LblID.Text));
            aracno.Durum = 2;
            db.TblAracAlimLog.Add(log);
            db.SaveChanges();
            XtraMessageBox.Show("Araç Kiralama İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            AracListele();
        }

        //Kiralanmak istenilen aracın tutarının hesaplanması
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = Convert.ToDateTime(DateAlimTarihi.DateTime);
            DateTime bitisTarihi = Convert.ToDateTime(DateTeslimTarihi.DateTime);
            TimeSpan fark = bitisTarihi - baslangicTarihi;
            int gunSayisi = fark.Days;
            if (gunSayisi < 0)
            {
                XtraMessageBox.Show("Tarih Seçimi Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sonuc = gunSayisi * Convert.ToInt32(LblUcret.Text);
                LblToplamUcret.Text = sonuc.ToString();
                BtnAracKiralamaGerceklestir.Enabled = true;
            }
        }
    }
}
