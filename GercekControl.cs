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
    public partial class GercekControl : UserControl
    {
        public GercekControl()
        {
            InitializeComponent();
            
        }

        MusteriKayit mk { get; set; }

        private void GercekControl_Load(object sender, EventArgs e)
        {

        }
    }
}
