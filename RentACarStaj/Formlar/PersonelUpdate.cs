using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarStaj.Entity;
using DevExpress.XtraEditors;

namespace RentACarStaj.Formlar
{
    public partial class PersonelUpdate : Form
    {
        public PersonelUpdate()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //personellerin gridcontrol objesinde gösterimi
        void PersonelListele()
        {
            var personelListesi = (from x in db.TblPersonel
                                   select new
                                   {
                                       x.ID,
                                       x.Ad,
                                       x.Soyad,
                                       x.Mail,
                                       x.Telefon,
                                       yetki = x.TblYetki.Yetki,
                                       cinsiyet = x.TblCinsiyet.Cinsiyet,
                                       x.Durum
                                   }).ToList();
            gridControl1.DataSource = personelListesi.Where(x => x.Durum == true && x.Ad != "-").ToList();
        }

        //lookupeditler için gerekli olan cinsiyet ve yetki bilgilerinin veri tabanından alınması
        void lookUpDoldur()
        {
            var cinsiyetListesi = (from x in db.TblCinsiyet
                                   select new
                                   {
                                       x.ID,
                                       x.Cinsiyet
                                   }).Where(x => x.Cinsiyet != "-").ToList();

            LookupCinsiyet.Properties.ValueMember = "ID";
            LookupCinsiyet.Properties.DisplayMember = "Cinsiyet";
            LookupCinsiyet.Properties.DataSource = cinsiyetListesi;

            var yetkiListesi = (from x in db.TblYetki
                                select new
                                {
                                    x.ID,
                                    x.Yetki,
                                }).ToList();

            LookupYetki.Properties.ValueMember = "ID";
            LookupYetki.Properties.DisplayMember = "Yetki";
            LookupYetki.Properties.DataSource = yetkiListesi;
        }

        private void PersonelUpdate_Load(object sender, EventArgs e)
        {
            PersonelListele();
            lookUpDoldur();
        }

        //gridcontrol üzerinden seçilen satırdaki bilgilerin labellara aktarımı
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
        }

        //girilen verilere göre personel tablosunda seçili olan personelin bilgilerinin değiştirilmesi
        private void BtnPersonelUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var personelUpdate = db.TblPersonel.Find(Convert.ToInt32(LblID.Text));
                personelUpdate.Ad = TxtAd.Text;
                personelUpdate.Soyad = TxtSoyad.Text;
                personelUpdate.Mail = TxtMail.Text;
                personelUpdate.Telefon = TxtTelefon.Text;
                personelUpdate.Cinsiyet = int.Parse(LookupCinsiyet.EditValue.ToString());
                personelUpdate.Yetki = int.Parse(LookupYetki.EditValue.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Personelin Bilgileri Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PersonelListele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Eksik Bilgi Girişi Yapıldı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
