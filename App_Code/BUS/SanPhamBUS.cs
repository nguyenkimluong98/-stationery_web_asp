using BTL_ASP;
using System.Data;

/// <summary>
/// Summary description for SanPhamBUS
/// </summary>
public class SanPhamBUS
{
    public DataTable LayDanhSachSP()
    {
        string query = "select * from SanPham";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhSach4SP(int maDM)
    {
        string query = "select TOP 4 * from SanPham inner join DanhMucSP on SanPham.maDM = DanhMucSP.maDM where SanPham.maDM=" + maDM;
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhSachTheoDM(string maDM)
    {
        string query = "select * from SanPham where maDM=" + maDM;
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhSachTheoNhom(string maNhom, string maDM)
    {
        string query = "select * from SanPham where maDM=" + maDM + " and maNhomSP=" + maNhom;
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayTopSanPham()
    {
        string query = @"select * from SanPham where maSP in (
                            select a.maSP from(select top 8 SanPham.maSP as maSP, SUM(ChiTietDonHang.soLuong) as total from ChiTietDonHang, SanPham where ChiTietDonHang.maSP = SanPham.maSP
                            group by SanPham.maSP
                            order by total DESC) a)";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LayDanhSachRandom(int top)
    {
        string query = "select TOP " + top + " * from SanPham where SanPham.maDM IN (1,2,3,4,6,7) ORDER BY NEWID()";
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LaySPCungLoai(string maNhomSP, string maDM, string maCu)
    {
        string query = "select * from SanPham where maNhomSP=" + maNhomSP + " and maDM=" + maDM + " and maSP<>" +maCu;
        return DAL.Instance.ExercuteQuery(query);
    }

    public DataTable LaySPById(string id)
    {
        string query = "select * from SanPham where maSP=" + id;
        return DAL.Instance.ExercuteQuery(query);
    }

    public int ThemSP(string tenSP, float giaBan, string chiTiet, string anhSP, int maNhomSP, int maDM)
    {
        string query = "insert into SanPham values(N'" + tenSP + "', " + giaBan + ", N'" + chiTiet + "', N'" + anhSP + "'," + maNhomSP + ", " + maDM + ")";
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int SuaSP(string id, string tenSP, float giaBan, string chiTiet, string anhSP, int maNhomSP, int maDM)
    {
        string query = "update SanPham set tenSP=N'" + tenSP + "', giaBan=" + giaBan + ", chiTiet=N'" + chiTiet + "', anhSP=N'" + anhSP + "', maNhomSP=" + maNhomSP + ", maDM=" + maDM + " where maSP=" + id;
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public int XoaSP(string id)
    {
        string query = "delete from SanPham where maSP=" + id;
        return DAL.Instance.ExercuteNonQuery(query);
    }

    public DataTable SearchSP(string textSearch)
    {
        string query = "select * from SanPham where TenSP like N'%" + textSearch + "%'";
        return DAL.Instance.ExercuteQuery(query);
    }
}