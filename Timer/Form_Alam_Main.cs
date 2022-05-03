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
    public partial class Form_Alam_Main : Form
    {
        //사용할 자식폼 생성 
        Form_Alam_Child child1 = new Form_Alam_Child();

        public Form_Alam_Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            child1.Text = "";
            child1.ControlBox = false;
            child1.Show();
        }
    }
}
