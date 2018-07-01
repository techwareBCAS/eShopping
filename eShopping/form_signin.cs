using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopping
{
    public partial class form_signin : Form
    {
        public form_signin()
        {
            InitializeComponent();
        }

        private void btn_u_login_Click(object sender, EventArgs e)
        {
            bool checker = this.login(txt_u_username.Text, txt_u_password.Text);
            if (checker == true)
            {
                MessageBox.Show("You have logged in");
            }
            else
            {
                MessageBox.Show("wrong Information");
            }

        }
        private bool login(string uname, string upass)
        {
            int count = tbl_userTableAdapter1.GetDataForLogin(uname, upass).Rows.Count;
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_r_signup_Click(object sender, EventArgs e)
        {
            bool validation_cheker = this.r_validation(txt_r_password.Text, txt_r_conpasswword.Text);
            if (validation_cheker == true)
            {
                bool checker = this.registration(txt_r_username.Text, txt_r_password.Text);
                if (checker == true)
                {
                    MessageBox.Show("You Have signed Up");
                }
            }
            else
            {
                MessageBox.Show("password not matching");
            }
        }
        private bool r_validation(string rpass, string rconpass)
        {
            if(rpass == rconpass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool registration(string rname, string rpass)
        {
            int checker = tbl_userTableAdapter1.InsertQueryforRegistration(rname, rpass);
            if (checker > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
