using BTL_ASP;
using System;
using System.Data;

/// <summary>
/// Summary description for DanhMucBUS
/// </summary>
public class DanhMucBUS
{
    public DataTable LayDanhSachDanhMuc()
    {
        string query = "select * from DanhMucSP";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhMucById(string id)
    {
        string query = "select * from DanhMucSP where maDM='" + id + "'";
        return DAL.Instance.ExercuteQuery(query);
    }

    public int ThemDanhMuc(string tenDM)
    {
        string query = "insert into DanhMucSP values(N'" + tenDM + "')";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int SuaDanhMuc(string id, string tenDM)
    {
        string query = "update DanhMucSP set tenDM = N'" + tenDM + "' where maDM='" + id + "'";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int XoaDanhMuc(string id)
    {
        string query = "delete from DanhMucSP where maDM='" + id + "'";
        Console.WriteLine("aaaaaa");
        return DAL.Instance.ExercuteNonQuery(query);
    }
}