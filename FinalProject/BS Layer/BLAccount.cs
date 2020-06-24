﻿using FinalProject.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BS_Layer
{
    public class BLAccount
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

        public DataTable getMenuAll()
        {
            return db.ExecuteQueryDataTable("SELECT THUCDON.ID,THUCDON.TEN as Tên,THUCDON.GIA as Giá, LOAI.TEN as Loại " +
                                            "FROM THUCDON " +
                                            "INNER JOIN LOAI " +
                                            "ON THUCDON.LOAI = LOAI.ID ", CommandType.Text);
        }

        public DataTable getMenuByID(string id)
        {
            return db.ExecuteQueryDataTable("SELECT THUCDON.ID,THUCDON.TEN,THUCDON.GIA, LOAI.TEN " +
                                            "FROM THUCDON " +
                                            "INNER JOIN LOAI " +
                                            "ON THUCDON.LOAI = LOAI.ID " + 
                                            "WHERE LOAI.ID = " + id, CommandType.Text);
        }
        public DataTable getStaffAll()
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID ", CommandType.Text);
        }
        public DataTable getChucVu(int id)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE CHUCVU.ID = " + id, CommandType.Text);
        }
        public DataTable getNVbyID(string id)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE NHANVIEN.ID = " + id, CommandType.Text);
        }
        public DataTable getNVbyName(string ten)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE NHANVIEN.HOTEN LIKE N'%" + ten+ "%'" , CommandType.Text);
        }
        public DataTable getNVbyPositionandSearchName(string search, int id)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE CHUCVU.ID = " + id + "AND NHANVIEN.HOTEN LIKE N'%" + search + "%' OR NHANVIEN.ID = "+search, CommandType.Text);

        }
        public bool AddNV(string Hoten, string cmnd, DateTime namsinh, int Luong, int Chucvu, ref string error)
        {
            string sqlString = "Insert Into NHANVIEN(HOTEN,CMND,NAMSINH,LUONG,CHUCVU) Values(N'" + Hoten + "','" + cmnd + "','"+ namsinh +"',"+Luong+","+ Chucvu +")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);

        }
    }
}
