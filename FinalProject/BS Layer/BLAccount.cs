﻿using FinalProject.DB_Layer;
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
            return db.ExecuteQueryDataTable("select * from TAIKHOAN", CommandType.Text);
        }

        public DataTable LayTaiKhoanByUsername(string Username, string Password)
        {
            return db.ExecuteQueryDataTable("select * from TAIKHOAN Where Username = '" + Username + "' and Password = '" + Password + "'", CommandType.Text);
        }
    }
}
