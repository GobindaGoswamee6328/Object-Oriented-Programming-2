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
    public partial class FormA : Form
    {
        public FormA()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            this.testLabel.Text = this.ourTxt.Text;
        }
    }
}
