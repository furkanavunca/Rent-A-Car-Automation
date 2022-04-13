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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();
        int kiralamaSayisi = 0, enbuyuk = 0, enkucuk = 0;

        //veri tabanındaki araç sayısının hesaplanması
        void AracSayisi()
        {
            var aracListesi = (from x in db.TblAraclar
                               select new
                               {
                                   x.ID,
                               }).ToList();
            int aracSayisi = aracListesi.Count();
            grafikOlustur(aracSayisi);
        }

        //veri tabanında bulunan araçların kiralama sayılarının grafiğe aktarımı
        void AracinKiralamaSayisi(int aracid)
        {
            var aracKiralamaSayim = (from x in db.TblAracAlimLog
                                     select new
                                     {
                                         marka = x.TblAraclar.Marka,
                                         model = x.TblAraclar.Model,
                                         x.AracNo
                                     }).ToList();
            int kiralamaDegeri = aracKiralamaSayim.Where(x => x.AracNo == aracid).Count();
            kiralamaSayisi = kiralamaDegeri;
            if (kiralamaSayisi > enbuyuk)
            {
                enbuyuk = kiralamaSayisi;
                var geciciDeger = db.TblAraclar.Find(aracid);
            }
            else if (kiralamaSayisi <= enkucuk)
            {
                enkucuk = kiralamaSayisi;
                var geciciDeger2 = db.TblAraclar.Find(aracid);
            }
        }

        //veri tabanında bulunan araç sayısına göre grafikte sütün sayısı oluşturma
        void grafikOlustur(int aracdeger)
        {
            for (int i = 1; i < aracdeger + 1; i++)
            {
                var findAracisimleri = db.TblAraclar.Find(i);
                string aracBilgileri = findAracisimleri.Marka + " " + findAracisimleri.Model;
                var findAracid = findAracisimleri.ID;
                AracinKiralamaSayisi(findAracid);
                chartControl1.Series["Series 1"].Points.AddPoint(aracBilgileri, kiralamaSayisi);
            }
        }

        //Veri tananında bulunan personellerin cinsiyet bakımından sınıflandırılıp hangi cinsiyetten kaç adet olduğunun hesaplanması
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
                string erkek = personel.Where(x => x.Cinsiyet == 1 && x.Durum == true).Count().ToString();
                chartControl2.Series["Series 1"].Points.AddPoint("Erkek", int.Parse(erkek));
            }
            else
            {
                string kadin = personel.Where(x => x.Cinsiyet == 2 && x.Durum == true).Count().ToString();
                chartControl2.Series["Series 1"].Points.AddPoint("Kadin", int.Parse(kadin));
            }

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            AracSayisi();
            personelToplam(1);
            personelToplam(2);
        }
    }
}
