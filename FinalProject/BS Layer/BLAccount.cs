using FinalProject.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BS_Layer
{
    class BLAccount
    {
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }
        public DataTable LAYTAIKHOAN()
        {
            return db.ExecuteQueryDataSet("select * from TAIKHOAN", CommandType.Text);
        }
    }
}
