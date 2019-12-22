using BTL_ASP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class QuanLi
{
    public static DataTable DangNhap(string taiKhoan, string matKhau)
    {
        string query = "select * from QuanLi where taiKhoan='" + taiKhoan + "' and matKhau='" + matKhau + "'";
        return DAL.Instance.ExercuteQuery(query);
    }

    public static DataTable LayDanhSachTaiKhoan()
    {
        string query = "select * from QuanLi";
        return DAL.Instance.ExercuteQuery(query);
    }

    public static DataTable LayTaiKhoanTheoTen(string taiKhoan)
    {
        string query = "select * from QuanLi where taiKhoan='" + taiKhoan + "'";
        return DAL.Instance.ExercuteQuery(query);
    }

    public static int ThemMoiTaiKhoan(string hoTen, string ngaySinh, string taiKhoan, string matKhau)
    {
        DataTable checkExist = LayTaiKhoanTheoTen(taiKhoan);
        if (checkExist.Rows.Count == 0)
        {
            string query = "insert into QuanLi values(N'" + hoTen + "','" + ngaySinh + "','" + taiKhoan + "','" + matKhau + "')";
            return DAL.Instance.ExercuteNonQuery(query);
        }

        return -1;
    }

    public static int ChinhSuaTaiKhoan(string taiKhoan, string hoTen, string ngaySinh, string matKhau)
    {
        string query = "update QuanLi set hoTen=N'" + hoTen + "', ngaySinh='" + ngaySinh + "', matKhau='" + matKhau + "' where taiKhoan='" + taiKhoan + "'";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public static int XoaTaiKhoan(string taiKhoan)
    {
        string query = "delete from QuanLi where taiKhoan='" + taiKhoan + "'";
        return DAL.Instance.ExercuteNonQuery(query);
    }
}