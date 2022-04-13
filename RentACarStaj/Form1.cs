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

namespace RentACarStaj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AracList frmAracList = new Formlar.AracList();
            frmAracList.MdiParent = this;
            frmAracList.Show();
        }

        private void BtnAracKirala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AracKirala frmAracKirala = new Formlar.AracKirala();
            frmAracKirala.MdiParent = this;
            frmAracKirala.Show();
        }

        private void BtnTeslimAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AracTeslimAl frmAracKirala = new Formlar.AracTeslimAl();
            frmAracKirala.MdiParent = this;
            frmAracKirala.Show();
        }

        private void BtnKiralamaLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.KiralamaLog frmKiralamaLog = new Formlar.KiralamaLog();
            frmKiralamaLog.MdiParent = this;
            frmKiralamaLog.Show();
        }

        private void BtnHasarliAracList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.HasarliAracList frmHasarliAracList = new Formlar.HasarliAracList();
            frmHasarliAracList.MdiParent = this;
            frmHasarliAracList.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelList frmPersonelList = new Formlar.PersonelList();
            frmPersonelList.MdiParent = this;
            frmPersonelList.Show();
        }

        private void BtnPersonelStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelStats frmPersonelStats = new Formlar.PersonelStats();
            frmPersonelStats.MdiParent = this;
            frmPersonelStats.Show();
        }

        private void BtnPersonelEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelAdd frmPersonelEkle = new Formlar.PersonelAdd();
            frmPersonelEkle.Show();
        }

        private void BtnPersonelGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelUpdate frmPersonelUpdate = new Formlar.PersonelUpdate();
            frmPersonelUpdate.MdiParent = this;
            frmPersonelUpdate.Show();
        }

        private void BtnPersonelStatsMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelStats frmPersonelStats = new Formlar.PersonelStats();
            frmPersonelStats.MdiParent = this;
            frmPersonelStats.Show();
        }

        private void BtnAracStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AracStats frmAracStats = new Formlar.AracStats();
            frmAracStats.MdiParent = this;
            frmAracStats.Show();
        }

        private void BtnCarStatsMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AracStats frmAracStats = new Formlar.AracStats();
            frmAracStats.MdiParent = this;
            frmAracStats.Show();
        }

        private void BtnMainPage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.MainPage frmMainPage = new Formlar.MainPage();
            frmMainPage.MdiParent = this;
            frmMainPage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formlar.MainPage frmMainPage = new Formlar.MainPage();
            frmMainPage.MdiParent = this;
            frmMainPage.Show();
        }
    }
}
