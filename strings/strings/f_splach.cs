using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strings
{
    public partial class f_splach : Form
    {
        public f_splach()
        {
            InitializeComponent();
        }
        //timer => 1 segundo
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTempo.Value += 1;

                if (pbTempo.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
