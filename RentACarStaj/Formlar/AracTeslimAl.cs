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
    public partial class AracTeslimAl : Form
    {
        public AracTeslimAl()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();
        //kiralanan araçların listesinin veri tabanından çekilmesi
        void KiralikAracListele()
        {
            var degerler = from x in db.TblAracAlimLog
                           select new
                           {
                               x.ID,
                               x.AracNo,
                               Marka = x.TblAraclar.Marka,
                               Model = x.TblAraclar.Model,
                               Plaka = x.TblAraclar.Plaka,
                               TeslimEden =  x.TblPersonel.Ad,
                               x.AlanAd,
                               x.AlanSoyad,
                               x.AlanTelefon,
                               Ehliyet = x.TblEhliyetTipleri.EhliyetTipi,
                               x.AlimTarihi,
                               x.TeslimTarihi,
                               Durum = x.TblDurum.Durum,
                               Ucret = x.TblAraclar.Ucret,
                               x.KiralamaUcreti
                           };
            gridControl1.DataSource = degerler.Where(x=>x.Durum == "Kiralandı").ToList();
        }

        //Araçların durumları için lookupedite gerekli verilerin çekilmesi
        void AracDurumları()
        {
            var durumlar = (from x in db.TblDurum
                            select new
                            {
                                x.ID,
                                x.Durum
                            }).ToList();
            LookUpHasar.Properties.ValueMember = "ID";
            LookUpHasar.Properties.DisplayMember = "Durum";
            LookUpHasar.Properties.DataSource = durumlar;
        }

        //Lookupedite personel isimlerinin çekilmesi
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
            LookUpPersonel.Properties.ValueMember = "ID";
            LookUpPersonel.Properties.DisplayMember = "Ad";
            LookUpPersonel.Properties.DataSource = personeller.Where(x => x.Durum == true && (x.Yetki == "Yönetici" || x.Yetki == "Kiralama Personeli"));
        }
        private void AracTeslimAl_Load(object sender, EventArgs e)
        {
            KiralikAracListele();
            AracDurumları();
            lookUpPersonel();
        }

        //Teslim alınması durumunda veri tabanında araç bilgilerinin güncelleştirilmesi
        private void BtnAracKiralamaGerceklestir_Click(object sender, EventArgs e)
        {
            try
            {             
                var id = int.Parse(LblID.Text);
                var no = int.Parse(lblAracNo.Text);
                var tarama = db.TblAracAlimLog.Find(id);
                tarama.Durum = int.Parse(LookUpHasar.EditValue.ToString());
                var arac = db.TblAraclar.Find(no);
                arac.Durum = int.Parse(LookUpHasar.EditValue.ToString());
                if (int.Parse(LookUpHasar.EditValue.ToString()) == 3)
                {
                    TblHasarLog hsrlog = new TblHasarLog();
                    hsrlog.AracNo = no;
                    hsrlog.HasarAciklama = "-";
                    hsrlog.Durum = int.Parse(LookUpHasar.EditValue.ToString());
                    db.TblHasarLog.Add(hsrlog);
                }
                db.SaveChanges();
                KiralikAracListele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgiler Eksik", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Gridcontrolde seçilen satırın labellara aktarımı
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                lblAracNo.Text = gridView1.GetFocusedRowCellValue("AracNo").ToString();
                LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                LblMarka.Text = gridView1.GetFocusedRowCellValue("Marka").ToString();
                LblModel.Text = gridView1.GetFocusedRowCellValue("Model").ToString();
                LblPlaka.Text = gridView1.GetFocusedRowCellValue("Plaka").ToString();
                LblAd.Text = gridView1.GetFocusedRowCellValue("AlanAd").ToString();
                LblSoyad.Text = gridView1.GetFocusedRowCellValue("AlanSoyad").ToString();
                LblTel.Text = gridView1.GetFocusedRowCellValue("AlanTelefon").ToString();
                LblEhliyet.Text = gridView1.GetFocusedRowCellValue("Ehliyet").ToString();
                LblPersonel.Text = gridView1.GetFocusedRowCellValue("TeslimEden").ToString();
                LblToplamUcret.Text = gridView1.GetFocusedRowCellValue("KiralamaUcreti").ToString();
                DateAlimTarihi.Text = gridView1.GetFocusedRowCellValue("AlimTarihi").ToString();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Kiralık Araç Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //Araç teslim alınırken ödenmesi gereken tutar
        private void simpleButton1_Click(object sender, EventArgs e)
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
                var ucret = gridView1.GetFocusedRowCellValue("Ucret").ToString();
                int sonuc = gunSayisi * Convert.ToInt32(ucret);
                LblHesaplananTutar.Text = sonuc.ToString();
                BtnAracKiralamaGerceklestir.Enabled = true;
            }
        }
    }
}
