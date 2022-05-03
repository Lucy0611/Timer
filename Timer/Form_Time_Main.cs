using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form_Time_Main : Form
    {
        public Form_Time_Main()
        {
            InitializeComponent();

            tmr_display.Enabled = true;
        }

        private void tmr_display_Tick(object sender, EventArgs e)
        {
            txt_realTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        private void btn_Alam_Click(object sender, EventArgs e)
        {
            Form f2 = new Form_Alam_Main();
            this.AddOwnedForm(f2);

            f2.Show();
        }
    }
}
