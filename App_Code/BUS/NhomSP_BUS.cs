using BTL_ASP;
using System.Data;

/// <summary>
/// Summary description for NhomSP_BUS
/// </summary>
public class NhomSP_BUS
{
    public DataTable LayDanhSachNhomSP()
    {
        string query = "select * from NhomSP inner join DanhMucSP on NhomSP.maDM=DanhMucSP.maDM";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhSachNhomSPOnly()
    {
        string query = "select * from NhomSP";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayNhomSPByTen(string maNhom, string maDM)
    {
        string query = "select * from NhomSP where maNhomSP=" + maNhom + " and maDM=" + maDM;
        return DAL.Instance.ExercuteQuery(query);
    }

    public int ThemNhomSP(string tenNhomSP, string maDM)
    {
        DataTable nhomSPs = DAL.Instance.ExercuteQuery("select * from NhomSP where maDM=" + maDM);
        int maNhomMoi = (int)nhomSPs.Rows[nhomSPs.Rows.Count - 1]["maNhomSP"];
        string query = "insert into NhomSP values(" + (maNhomMoi + 1) + ", N'" + tenNhomSP + "', " + maDM + ")";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int SuaNhomSP(string maSPcu, string maDMcu, string tenNhomSP, string maDM)
    {
        string query = "update NhomSP set tenNhomSP = N'" + tenNhomSP + "', maDM=" + maDM + " where maNhomSP=" + maSPcu + " and maDM=" + maDMcu;
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int XoaNhomSP(string maNhom, string maDM)
    {
        string query = "delete from NhomSP where maNhomSP=" + maNhom + " and maDM=" + maDM;
        return DAL.Instance.ExercuteNonQuery(query);
    }
}