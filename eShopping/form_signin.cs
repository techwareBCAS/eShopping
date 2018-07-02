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
    public partial class Form_signin : Form
    {
        public Form_signin()
        {
            InitializeComponent();
        }

        private void btn_u_login_Click(object sender, EventArgs e)
        {
            user u = new user();
            
            bool checker = u.login(txt_u_username.Text, txt_u_password.Text);
            if (checker == true)
            {
                Form_DashBoard d = new Form_DashBoard();
                d.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong Information");
            }

        }

        private void btn_r_signup_Click(object sender, EventArgs e)
        {
            user u = new user();
            bool validation_cheker = this.r_validation(txt_r_password.Text, txt_r_conpasswword.Text);
            if (validation_cheker == true)
            {
                bool checker = u.signup(txt_r_username.Text, txt_r_password.Text);
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
    }
}
