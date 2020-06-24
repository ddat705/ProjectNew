using FinalProject.DB_Layer;
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
            return db.ExecuteQueryDataTable(" Select C.* " +
                                  " From(SELECT A.username, A.LoaiTaiKhoan, B.MaNV, B.HoVaTen, B.cmnd, B.ChucVu " +
                                  " FROM(Select TAIKHOAN.USERNAME AS username, TAIKHOAN.IDNhanVien, TYPEACCOUNT.name as LoaiTaiKhoan" +
                                  " FROM TAIKHOAN " +
                                  " INNER JOIN TYPEACCOUNT " +
                                  " ON TAIKHOAN.TYPEACCOUNT = TYPEACCOUNT.ID) A " +
                                  " INNER JOIN(Select NHANVIEN.ID as MaNV, NHANVIEN.HOTEN as HoVaTen, NHANVIEN.CMND as cmnd, CHUCVU.CHUCVU as ChucVu " +
                                  " FROM NHANVIEN " +
                                  " INNER JOIN CHUCVU " +
                                  " ON NHANVIEN.CHUCVU = CHUCVU.ID) B " +
                                  " ON A.IDNhanVien = B.MaNV) C , TAIKHOAN " +
                                  " WHERE TAIKHOAN.USERNAME = C.username and TAIKHOAN.USERNAME = '" + Username + "' and TAIKHOAN.PASSWORD = '" + Password + "'; ", CommandType.Text);

            //return db.ExecuteQueryDataTable("select * from TAIKHOAN Where Username = '" + Username + "' and Password = '" + Password + "'", CommandType.Text);
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
                                            "WHERE THUCDON.ID = " + id, CommandType.Text);
        }

        public DataTable getMenuByIDAndLoai(string idMenu, string idLoai)
        {
            return db.ExecuteQueryDataTable("SELECT THUCDON.ID,THUCDON.TEN,THUCDON.GIA, LOAI.TEN " +
                                            "FROM THUCDON " +
                                            "INNER JOIN LOAI " +
                                            "ON THUCDON.LOAI = LOAI.ID " +
                                            "WHERE THUCDON.ID = " + idMenu +
                                            " AND LOAI.ID = " + idLoai, CommandType.Text);
        }

        public DataTable getMenuByName(string name)
        {
            return db.ExecuteQueryDataTable("SELECT THUCDON.ID,THUCDON.TEN,THUCDON.GIA, LOAI.TEN " +
                                            "FROM THUCDON " +
                                            "INNER JOIN LOAI " +
                                            "ON THUCDON.LOAI = LOAI.ID " +
                                            "WHERE THUCDON.TEN LIKE N'%" + name + "%'", CommandType.Text);
        }

        public DataTable getMenuByNameAndLoai(string idMenu, string idLoai)
        {
            return db.ExecuteQueryDataTable("SELECT THUCDON.ID,THUCDON.TEN,THUCDON.GIA, LOAI.TEN " +
                                            "FROM THUCDON " +
                                            "INNER JOIN LOAI " +
                                            "ON THUCDON.LOAI = LOAI.ID " +
                                            "WHERE THUCDON.TEN LIKE N'%" + idMenu + "%'" +
                                            " AND LOAI.ID = " + idLoai, CommandType.Text);
        }

        public DataTable getMenuByLoai(string id)
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
        public DataTable getChucVu(string id)
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

        public DataTable getStaffByIDAndPosition(string id, string chucvu)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE NHANVIEN.ID = " + id +
                                            " AND CHUCVU.ID = " + chucvu, CommandType.Text);
        }
        public DataTable getStaffByNameAndPosition(string hoten, string chucvu)
        {
            return db.ExecuteQueryDataTable("SELECT NHANVIEN.ID, NHANVIEN.HOTEN AS 'HỌ TÊN', NHANVIEN.CMND, NHANVIEN.NAMSINH AS 'NĂM SINH', NHANVIEN.LUONG AS 'LƯƠNG', CHUCVU.CHUCVU AS 'CHỨC VỤ' " +
                                            "FROM NHANVIEN " +
                                            "INNER JOIN CHUCVU " +
                                            "ON NHANVIEN.CHUCVU = CHUCVU.ID " +
                                            "WHERE NHANVIEN.HOTEN LIKE N'%" + hoten + "%'" +
                                            " AND CHUCVU.ID = " + chucvu, CommandType.Text);
        }

        public bool AddNV(string Hoten, string cmnd, string namsinh, string Luong, string Chucvu, string error)
        {
            return db.MyExecuteNonQuery("Insert Into NHANVIEN(HOTEN,CMND,NAMSINH,LUONG,CHUCVU) Values(N'" + Hoten + "','" + cmnd + "','"+ namsinh +"',"+Luong+","+ Chucvu +")", CommandType.Text, ref error);
        }

        public void deleteMenuByID(string id)
        {
            db.ExecuteQueryDataTable("DELETE " +
                                             "FROM THUCDON " +
                                             "WHERE THUCDON.ID = " + id, CommandType.Text);
        }

        public bool addMenu(string ten, string gia, string loai, string err)
        {

            return db.MyExecuteNonQuery("INSERT INTO THUCDON(TEN,GIA,LOAI) VALUES ('" +
                      ten + "'," +
                      gia + "," +
                      loai + ")", CommandType.Text, ref err);
        }
        public bool updateMenuByID(string id, string ten, string gia, string loai, string err)
        {

            return db.MyExecuteNonQuery("UPDATE THUCDON SET TEN = '" +
                      ten + "', GIA =" +
                      gia + ", LOAI =" +
                      loai + " WHERE ID = " + 
                      id, CommandType.Text, ref err);
        }
        public bool UpdateNV(string id, string Hoten, string cmnd, string namsinh, string Luong, string Chucvu, string error)
        {
            return db.MyExecuteNonQuery("Update NHANVIEN Set HOTEN = '" + Hoten + "', CMND = '" + cmnd + "', NAMSINH = '" + namsinh + "', LUONG = " + Luong + ", CHUCVU = " + Chucvu + " WHERE ID = "+id, CommandType.Text, ref error);
        }
        public void DeleteStaff(string id)
        {
            db.ExecuteQueryDataTable("DELETE FROM NHANVIEN WHERE NHANVIEN.ID = " + id, CommandType.Text);
        }
    }
}
