using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStartF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this.txtInfo.Text, this);
            this.Visible = false;
            MessageBox.Show("Form 2 loading");
            f2.Visible = true;

        }
    }
}
