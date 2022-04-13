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
using RentACarStaj.Formlar;

namespace RentACarStaj.Formlar
{
    public partial class AracList : Form
    {
        public AracList()
        {
            InitializeComponent();
        }

        DBRentACarEntities1 db = new DBRentACarEntities1();

        //araçların listelenmesi
        void Listeleme()
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
            gridControl1.DataSource = degerler.ToList();
        }
        private void AracList_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
    }
}
