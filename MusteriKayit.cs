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
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();

        }
        DataTable dt;
        OracleDataAdapter adpt;
        
        
        void kaydet()
        {
            fonksiyon.SqlCalistir(fonksiyon.db_Connection, "insert into cari (cari_ad,vergi_d) values ('" +Formlar.gk.CariAd.Text + "','"+Formlar.gk.VergiD.Text+"')");

        }
        //" + gercek.CariAd.Text + "
        //" + gercek.VergiD.Text + "
        void listele()
        {
            dt = new DataTable();
            adpt = new OracleDataAdapter("select * from cari",fonksiyon.db_Connection);
            adpt.Fill(dt);
            GridListe.DataSource = dt;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn==false)
            {
                panel3.Controls.Clear();
                TuzelControl tk = new TuzelControl();
                panel3.Controls.Add(tk);
                tk.Show();
                tk.Dock = DockStyle.Fill;
                tk.BringToFront();
            }
            if (toggleSwitch1.IsOn == true)
            {
                            
                panel3.Controls.Clear();
                GercekControl gk = new GercekControl();
                panel3.Controls.Add(gk);
                gk.Show();
                gk.Dock = DockStyle.Fill;
                gk.BringToFront();
            }

        }

        private void CheckEfatura_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            kaydet();
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            TuzelControl tk = new TuzelControl();
            panel3.Controls.Add(tk);
            tk.Show();
            tk.Dock = DockStyle.Fill;
            tk.BringToFront();
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
