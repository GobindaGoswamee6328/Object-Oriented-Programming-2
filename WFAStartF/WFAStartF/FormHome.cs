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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = this.txtUsername.Text;
            this.lblPassword.Text = this.txtPassword.Text;
            this.lblDepartment.Text = this.cmbDepartment.Text;
            this.lblDOB.Text = this.dtpDOB.Text;
            if (this.rbUndergraduate.Checked)
                this.lblProgram.Text = "Under Graduate";
            else if(this.rbGraduate.Checked)
                this.lblProgram.Text = this.rbGraduate.Text;


            this.pnlOutput.Visible = true;
            MessageBox.Show("Showing Data");
            this.pnlInformation.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = "";
            this.lblPassword.Text = "";
            this.lblDepartment.Text = "abcd";
            this.lblDOB.Text = "";
            this.lblProgram.Text = "";

            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbDepartment.SelectedIndex = -1;//this.cmbDepartment.Text = "";
            this.dtpDOB.Text = "";
            this.rbGraduate.Checked = false;
            this.rbUndergraduate.Checked = false;

            this.pnlOutput.Hide();
            MessageBox.Show("Clearing Data");
            this.pnlInformation.Show();
        }
    }
}
