using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WFALoginAppDB
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB;Initial Catalog=hspringdb;User ID=sa;Password=P@$$w0rd");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from UserInfo;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            var i = ds.Tables[0].Rows[0][3].ToString();
            MessageBox.Show(i);

            sqlcon.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.UseSystemPasswordChar)
                this.txtPassword.UseSystemPasswordChar = false;
            else
                this.txtPassword.UseSystemPasswordChar = true;
        }
    }
}


//if (this.txtUserID.Text == "bruce" && this.txtPassword.Text == "123")
//{
//    MessageBox.Show("Login Valid");
//}
//else if (this.txtUserID.Text == "clerk" && this.txtPassword.Text == "456")
//{
//    MessageBox.Show("Login Valid");
//}
//else
//{
//    MessageBox.Show("Login Invalid");
//}
