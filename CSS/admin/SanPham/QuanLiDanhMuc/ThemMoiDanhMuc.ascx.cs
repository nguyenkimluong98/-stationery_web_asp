using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiDanhMuc_ThemMoi_ThemMoiDanhMuc : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            if (id != "")
            {
                HienThiThongTin(id);
            }
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "chinh-sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";

            DataTable dt = new DataTable();
            dt = danhMucBUS.LayDanhMucById(id);
            if (dt.Rows.Count > 0)
            {
                tbTenDanhMuc.Text = dt.Rows[0]["tenDM"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
        }

    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "chinh-sua")
        {
            if (danhMucBUS.SuaDanhMuc(id,tbTenDanhMuc.Text) > 0)
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã sửa danh mục: " + tbTenDanhMuc.Text + "</div>";
            }
        }
        else
        {
            if (danhMucBUS.ThemDanhMuc(tbTenDanhMuc.Text) > 0)
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã thêm danh mục: " + tbTenDanhMuc.Text + "</div>";
            }
        }
    }

    void ResetControl()
    {
        tbTenDanhMuc.Text = "";
        Response.Redirect("Admin.aspx?module=san-pham&cat=qldm");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}