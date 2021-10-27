using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ETFZiraat
{
    public partial class MalzemeKarti : Form
    {
        public MalzemeKarti()
        {
            InitializeComponent();
        }

        DataTable dt;
        OracleDataAdapter adpt;
        void readtrue()
        {
            StokKoduTxt.Enabled = true;
            MalAdiTxt.Enabled = true;
            GrupCombo.Enabled = true;
            BarkodTxt.Enabled = true;
            AlisFiyTxt.Enabled = true;
            KdvTxt.Enabled = true;
            BirimCombo.Enabled = true;
            MiktarTxt.Enabled = true;
            Fiyat1Txt.Enabled = true;
            Fiyat2Txt.Enabled = true;
            AktifMadTxt.Enabled = true;
            FirmaAdiTxt.Enabled = true;
            FirmaKoduTxt.Enabled = true;
            RuhsatTarDtp.Enabled = true;
            FormulasyonTxt.Enabled = true;
            RuhsatAlinanTxt.Enabled = true;
            HastaZararTxt.Enabled = true;
            KritikTxt.Enabled = true;
            AktifChk.Enabled = true;
        }
        void readfalse()
        {
            StokKoduTxt.Enabled = false;
            MalAdiTxt.Enabled = false;
            GrupCombo.Enabled = false;
            BarkodTxt.Enabled = false;
            AlisFiyTxt.Enabled = false;
            KdvTxt.Enabled = false;
            BirimCombo.Enabled = false;
            MiktarTxt.Enabled = false;
            Fiyat1Txt.Enabled = false;
            Fiyat2Txt.Enabled = false;
            AktifMadTxt.Enabled = false;
            FirmaAdiTxt.Enabled = false;
            FirmaKoduTxt.Enabled = false;
            RuhsatTarDtp.Enabled = false;
            FormulasyonTxt.Enabled = false;
            RuhsatAlinanTxt.Enabled = false;
            HastaZararTxt.Enabled = false;
            KritikTxt.Enabled = false;
            AktifChk.Enabled = false;
        }
        private void MalzemeKarti_Load(object sender, EventArgs e)
        {
            readfalse();
            listele();

        }
        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            readtrue();
        }
        void listele()
        {
            dt = new DataTable();
            adpt = new OracleDataAdapter("select * from stok", fonksiyon.db_Connection);
            adpt.Fill(dt);
            GridListe.DataSource = dt;
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            fonksiyon.SqlCalistir(fonksiyon.db_Connection, "insert into stok (stok_kod,malzeme_adi) values ('" + StokKoduTxt.Text + "','" + MalAdiTxt.Text + "')");
        }
    }
}
