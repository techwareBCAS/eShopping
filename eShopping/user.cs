using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopping
{
    class user
    {
        DataSet1TableAdapters.tbl_userTableAdapter tbl_user = new DataSet1TableAdapters.tbl_userTableAdapter();

        public bool login(string uname, string upass)
        {
            int count = tbl_user.GetDataForLogin(uname, upass).Rows.Count;
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool signup(string rname, string rpass)
        {
            int checker = tbl_user.InsertQueryforRegistration(rname, rpass);
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
