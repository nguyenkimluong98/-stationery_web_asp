using BTL_ASP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DonHang
/// </summary>
public class DonHang
{
    public static int ThemDonHang(string hoTen, string dienThoai, string email, string diaChi)
    {
        string query = "insert into DonHang (hoTen, dienThoai, email, diaChi) values(N'" + hoTen + "', '"+dienThoai+"', '"+email+"', N'"+diaChi+"')";

        if (DAL.Instance.ExercuteNonQuery(query) > 0)
        {
            int maDHVuaTao = (int)DAL.Instance.ExercuteScalar("SELECT TOP 1 maDH FROM DonHang ORDER BY maDH DESC");
            return maDHVuaTao;
        }
        else return -1;
    }

    public static DataTable LayDanhSachDonHang()
    {
        string query = "SELECT * FROM DonHang ORDER BY maDH DESC";
        return DAL.Instance.ExercuteQuery(query);
    }

    public static DataTable LayDonHangTheoID(string id)
    {
        string query = "SELECT * FROM DonHang where MaDH=" + id;
        return DAL.Instance.ExercuteQuery(query);
    }

    public static int CapNhatTinhTrangDonHang(string id, string tinhTrang)
    {
        string query = "update DonHang set tinhTrang=" + tinhTrang + " where maDH=" + id;
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public static int XoaDonHang(string id)
    {
        string query = "delete from DonHang where maDH=" + id;
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public static DataTable LayChiTietDonHang(string id)
    {
        string query = "select * from ChiTietDonHang, DonHang, SanPham where ChiTietDonHang.maDH = DonHang.maDH and ChiTietDonHang.maSP = SanPham.maSP and ChiTietDonHang.maDH =" + id;
        return DAL.Instance.ExercuteQuery(query);
    }
}