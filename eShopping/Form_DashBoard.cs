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
    public partial class Form_DashBoard : Form
    {
        public Form_DashBoard()
        {
            InitializeComponent();
        }

        private void btn_Market_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_market.Height;
            sidepanel.Top = btn_market.Top;
        }
        private void btn_products_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_products.Height;
            sidepanel.Top = btn_products.Top;
        }
        private void btn_cart_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_cart.Height;
            sidepanel.Top = btn_cart.Top;
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_settings.Height;
            sidepanel.Top = btn_settings.Top;
        }
        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
