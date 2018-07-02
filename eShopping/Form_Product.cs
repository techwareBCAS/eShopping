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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
        }
        public string my_product { get; set; }
        public decimal my_price { get; set; }
        public int my_qty { get; set; }
        public string my_description { get; set; }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.my_product = txt_p_name.Text;
            this.my_price = nud_p_price.Value;
            this.my_qty = Convert.ToInt32(nud_p_qty.Value);
            this.my_description = txt_p_description.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
