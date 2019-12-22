using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiNhomSanPham_ThemMoiDanhSachNhomSanPham : System.Web.UI.UserControl
{
    string thaotac = "";
    string id = "";
    string madm = "";
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    DataTable dtDM = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (Request.QueryString["madm"] != null)
            madm = Request.QueryString["madm"];

        dtDM = danhMucBUS.LayDanhSachDanhMuc();

        if (!IsPostBack)
        {
            LayDanhMuc();
            HienThiThongTin();
        }
    }

    private void LayDanhMuc()
    {
        ddlDanhMuc.Items.Clear();
        for (int i = 0; i < dtDM.Rows.Count; i++)
        {
            ddlDanhMuc.Items.Add(new ListItem(dtDM.Rows[i]["tenDM"].ToString(), dtDM.Rows[i]["maDM"].ToString()));
        }
    }

    private void HienThiThongTin()
    {
        if (thaotac == "chinh-sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";

            DataTable dt = new DataTable();
            dt = nhomSP_BUS.LayNhomSPByTen(id, madm);
            if (dt.Rows.Count > 0)
            {
                tbTenNhomSanPham.Text = dt.Rows[0]["tenNhomSP"].ToString();
            }
            ddlDanhMuc.SelectedValue = madm;
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
            if (nhomSP_BUS.SuaNhomSP(id, madm, tbTenNhomSanPham.Text, ddlDanhMuc.SelectedValue) > 0)
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã sửa nhóm sản phẩm: " + tbTenNhomSanPham.Text + "</div>";
            }
        }
        else
        {
            if (nhomSP_BUS.ThemNhomSP(tbTenNhomSanPham.Text, ddlDanhMuc.SelectedValue) > 0)
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã thêm nhóm sản phẩm: " + tbTenNhomSanPham.Text + "</div>";
            }
        }
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        tbTenNhomSanPham.Text = "";
        Response.Redirect("Admin.aspx?module=san-pham&cat=qlnsp");
    }
}