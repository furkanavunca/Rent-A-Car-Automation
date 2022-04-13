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
    public partial class AracStats : Form
    {
        public AracStats()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();
        int kiralamaSayisi = 0, enbuyuk = 0, enkucuk = 0;
        
        //Veri tabanında kaç tane aracın olduğunu hesaplayarak grafikte bulunması gereken sütün sayısını oluşturma
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

        //Araçların kaç kere kiralandığını grafiklere aktarma ve en çok, en az kiralanan aracın hesaplanması
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
                LblEnCok.Text = geciciDeger.Marka + " " + geciciDeger.Model;
            }
            else if (kiralamaSayisi <= enkucuk)
            {
                enkucuk = kiralamaSayisi;
                var geciciDeger2 = db.TblAraclar.Find(aracid);
                LblEnAz.Text = geciciDeger2.Marka + " " + geciciDeger2.Model;
            }
        }

        //Sütünlara isimlerin aktarılması
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

        private void AracStats_Load(object sender, EventArgs e)
        {
            AracSayisi();
        }
    }
}
