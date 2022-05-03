using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Timer
{
    public partial class Form_Alam_Child : Form
    {
        public Form_Alam_Child()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form almaMain = new Form_Alam_Main();

            String path = @"..\..\alamDatabase.txt";
            String content = mtxt_alamSetting.Text.Substring(0, 2) + mtxt_alamSetting.Text.Substring(3, 2);

            if (File.Exists(path))
            {
                TxtWrite(path, content);
                MessageBox.Show(mtxt_alamSetting.Text + "알람 저장 완료");
            }
           
        }

        private void TxtWrite(String path, String content)
        {
            StreamWriter writer;
            writer = File.AppendText(path);
            writer.WriteLine(content);
            writer.Close();
        }

    }
}
