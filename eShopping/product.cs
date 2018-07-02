using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopping
{
    class product
    {
        DataSet1TableAdapters.tbl_productTableAdapter tbl_user = new DataSet1TableAdapters.tbl_productTableAdapter();

        public product()
        {
            //empty
        }
        public bool add(string p_product, decimal p_price, int p_qty, string p_description)
        {
            int checker = tbl_user.InsertQueryForProduct(p_product, p_price, p_qty, p_description);
            if (checker > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete(int p_id)
        {
            int checker = tbl_user.DeleteQueryForProduct(p_id);
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
