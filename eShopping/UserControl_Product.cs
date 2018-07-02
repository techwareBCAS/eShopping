using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopping
{
    public partial class UserControl_Product : UserControl
    {
        DataSet1TableAdapters.tbl_productTableAdapter tbl_user = new DataSet1TableAdapters.tbl_productTableAdapter();
        public UserControl_Product()
        {
            InitializeComponent();
        }
        private void UserControl_Product_Load(object sender, EventArgs e)//in progress
        {
            DataSet1.tbl_productDataTable dt = new DataSet1.tbl_productDataTable();
            tbl_user.FillForProduct(dt);

            foreach (DataColumn dc in dt.Columns)
            {
                listView_Product.Columns.Add(dc.ToString());
            }   
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_Product fp = new Form_Product();
            fp.DialogResult = fp.ShowDialog();

            if (fp.DialogResult == DialogResult.OK)
            {
                product p = new product();
                bool checker = p.add(fp.my_product, fp.my_price, fp.my_qty, fp.my_description);
                if (checker == true)
                {
                    MessageBox.Show("product added");
                }
                else
                {
                    MessageBox.Show("did not add");
                }
            }
        }
    }
}
