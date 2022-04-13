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

namespace RentACarStaj.Formlar
{
    public partial class PersonelStats : Form
    {
        public PersonelStats()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //Cinsiyet dağılım oranlarının hesaplanarak labellara aktarılması
        void CinsiyetOrani()
        {
            int kadin = Convert.ToInt32(LblKadinPersonel.Text);
            int erkek = Convert.ToInt32(LblErkekPersonel.Text);
            int toplamCalisan = kadin + erkek;
            if (erkek > kadin)
            {
                double sonuc = 100 * erkek / toplamCalisan;
                LblCinsiyetOran.Text = "Çalışanların % " + sonuc.ToString() + " kadarı";
                LblCinsiyet.Text = "Erkek";
            }
            else if (kadin > erkek)
            {
                double sonuc = 100 * kadin / toplamCalisan;
                LblCinsiyetOran.Text = "Çalışanların % " + sonuc.ToString() + " kadarı";
                LblCinsiyet.Text = "Kadın";
            }
            else
            {
                LblCinsiyetOran.Text = "Çalışanların Oranı Eşit";
                LblCinsiyet.Visible = false;
            }
            
        }

        //veri tabanında bulunan personellerin cinsiyetlerine göre kaç kişi olduklarının hesaplanması
        void personelToplam(int a)
        {
            var personel = (from x in db.TblPersonel
                            select new
                            {
                                x.Ad,
                                x.Durum,
                                x.Cinsiyet
                            }).ToList();
            if (a == 1)
            {
                LblErkekPersonel.Text = personel.Where(x => x.Cinsiyet == 1 && x.Durum == true).Count().ToString();
            }
            else
            {
                LblKadinPersonel.Text = personel.Where(x => x.Cinsiyet == 2 && x.Durum == true).Count().ToString();
            }
            
        }

        //gridcontrol objesine veri tabanında bulunan personel bilgilerinin aktarımı
        void PersonelListele()
        {
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Mail,
                                x.Telefon,
                                x.Cinsiyet,
                                x.Durum
                            }).ToList();
            gridControl1.DataSource = degerler.Where(x => x.Ad != "-" && x.Durum == true);
        }

        private void PersonelStats_Load(object sender, EventArgs e)
        {
            PersonelListele();
            personelToplam(1);
            personelToplam(2);
            CinsiyetOrani();
            chartControl1.Series["Oranlar"].Points.AddPoint("Erkek", int.Parse(LblErkekPersonel.Text));
            chartControl1.Series["Oranlar"].Points.AddPoint("Kadin", int.Parse(LblKadinPersonel.Text));
        }
    }
}
