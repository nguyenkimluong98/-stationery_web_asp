using BTL_ASP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChiTietDH
/// </summary>
public class ChiTietDH
{
    public static int ThemChiTietDH(int soLuong, int maSP, int maDH)
    {
        string query = "insert into ChiTietDonHang values(" + soLuong + "," + maSP + "," + maDH + ")";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public static DataTable LayChiTietDH(int maDH)
    {
        string query = "select * from ChiTietDonHang where maDH=" + maDH;
        return DAL.Instance.ExercuteQuery(query);
    }
}