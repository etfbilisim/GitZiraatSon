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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST =93.177.103.215)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = ORCL))); User Id =ZIRAAT; Password =Pa$$w0rd;");
        DataTable dt;
        OracleDataAdapter adpt;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            dt = new DataTable();

            adpt = new OracleDataAdapter("select * from customer",con);
            adpt.Fill(dt);
           // gridControl1.DataSource = dt;
            con.Close();
        }

        private void MusteriKayit_Click(object sender, EventArgs e)
        {
            Formlar.ck.MdiParent = this;
            Formlar.ck.Show();

        }
    }
}
