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
    public partial class Form2 : Form
    {
        private Form1 F1 { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string info, Form1 f1) : this()
        {
            this.lblInfo.Text += info;
            this.F1 = f1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //this.Close();
            this.Hide();
            MessageBox.Show("Loading previous Form1");
            this.F1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
