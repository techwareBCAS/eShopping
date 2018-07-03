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
        product p = new product();

        public UserControl_Product()
        {
            InitializeComponent();
        }
        private void UserControl_Product_Load(object sender, EventArgs e)//in progress
        {
            dgv_refresh();
        }
        private void dgv_refresh()
        {
            DataSet1.tbl_productDataTable dt = new DataSet1.tbl_productDataTable();
            tbl_user.FillForProduct(dt);
            dataGridView_Product.DataSource = null;
            dataGridView_Product.Rows.Clear();
            dataGridView_Product.DataSource = dt;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_Product fp = new Form_Product();
            fp.DialogResult = fp.ShowDialog();

            if (fp.DialogResult == DialogResult.OK)
            {
                bool checker = p.add(fp.my_product, fp.my_price, fp.my_qty, fp.my_description);
                if (checker == true)
                {
                    dgv_refresh();
                    MessageBox.Show("Product added");
                }
                else
                {
                    MessageBox.Show("did not add");
                }
            }
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int  myrow = Convert.ToInt32(dataGridView_Product.CurrentRow.Index);
            int p_id = Convert.ToInt32(dataGridView_Product.Rows[myrow].Cells[0].Value.ToString());
            bool checker = p.delete(p_id);
            if (checker == true)
            {
                dgv_refresh();
                MessageBox.Show("Product Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete for a reason");
            }
        }
    }
}
