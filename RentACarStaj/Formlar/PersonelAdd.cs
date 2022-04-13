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
    public partial class PersonelAdd : Form
    {
        public PersonelAdd()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //Lookupedit 1 ve 2 içinde bulunan verilerin veri tabanından çekilerek aktarımlarının sağlanması
        void LookUpDoldur()
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

        private void PersonelAdd_Load(object sender, EventArgs e)
        {
            LookUpDoldur();
        }

        //Girilen verilerin Personel tablosuna eklenmesi
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TblPersonel personelEkle = new TblPersonel();
                personelEkle.Ad = TxtAd.Text;
                personelEkle.Soyad = TxtSoyad.Text;
                personelEkle.Mail = TxtMail.Text;
                personelEkle.Telefon = TxtTelefon.Text;
                personelEkle.Cinsiyet = int.Parse(LookupCinsiyet.EditValue.ToString());
                personelEkle.Yetki = int.Parse(LookupYetki.EditValue.ToString());
                personelEkle.Durum = true;
                db.TblPersonel.Add(personelEkle);
                db.SaveChanges();
                XtraMessageBox.Show("Personel Ekleme İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Eksik Bilgi Girişi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
