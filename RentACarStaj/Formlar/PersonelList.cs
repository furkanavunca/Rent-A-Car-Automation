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
    public partial class PersonelList : Form
    {
        public PersonelList()
        {
            InitializeComponent();
        }
        DBRentACarEntities1 db = new DBRentACarEntities1();

        //veri tabanında bulunan personel bilgisinin gridcontrol objesine aktarılması
        void PersonelListele()
        {
            var listele = (from x in db.TblPersonel
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
            gridControl1.DataSource = listele.Where(x => x.Ad != "-").ToList();
        }

        private void PersonelList_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        //gridcontrol objesinde seçilen satırın labellara aktarılması
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LblID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            LblAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            LblSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            LblMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            LblTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            LblYetki.Text = gridView1.GetFocusedRowCellValue("yetki").ToString();
            LblCinsiyet.Text = gridView1.GetFocusedRowCellValue("cinsiyet").ToString();
            string durum = gridView1.GetFocusedRowCellValue("Durum").ToString();
            if (durum == "True")
            {
                LblDurum.Text = "Çalışıyor";
            }
            else
            {
                LblDurum.Text = "İşten Ayrıldı";
            }
        }

        //seçilen personelin işten çıkartılarak veri tabanına işlenmesi
        private void BtnPersonelRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var id = db.TblPersonel.Find(Convert.ToInt32(LblID.Text));
                id.Durum = false;
                db.SaveChanges();
                XtraMessageBox.Show("Personel Çıkartma İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PersonelListele();

            }
            catch (Exception)
            {
                XtraMessageBox.Show("İşlem Sırasında Bir Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Daha önceden işten çıkarılmış personelin işe geri alınması durumunda veri tabanının güncellenmesi
        private void BtnPersonelGeriAl_Click(object sender, EventArgs e)
        {
            try
            {
                var id = db.TblPersonel.Find(Convert.ToInt32(LblID.Text));
                id.Durum = true;
                db.SaveChanges();
                XtraMessageBox.Show("Personel Tekrardan İşe Alındı", "Başırılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PersonelListele();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("İşlem Sırasında Bir Hata Oluştı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
