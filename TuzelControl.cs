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
    public partial class TuzelControl : UserControl
    {
        public TuzelControl()
        {
            InitializeComponent();
        }

        private void TuzelControl_Load(object sender, EventArgs e)
        {

        }

        private void CheckEfatura_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEfatura.Checked == true)
            {
                LabelPKAdres.Visible = true;
                TextPkAdres.Visible = true;
            }
            else
            {
                LabelPKAdres.Visible = false;
                TextPkAdres.Visible = false;
            }
        }
    }
}
