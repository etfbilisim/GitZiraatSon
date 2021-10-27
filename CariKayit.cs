using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETFZiraat
{
    public partial class CariKayit : Form
    {
        public CariKayit()
        {
            InitializeComponent();
        }

        private void CheckEfatura_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEfatura.Checked)
            {
                TextEfaturagb.Visible = true;
                TextEfaturaPk.Visible = true;
                LabelEfaturaGb.Visible = true;
                LabelEfaturaPk.Visible = true;
            }
            else
            {
                TextEfaturagb.Visible = false;
                TextEfaturaPk.Visible = false;
                LabelEfaturaGb.Visible = false;
                LabelEfaturaPk.Visible = false;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
