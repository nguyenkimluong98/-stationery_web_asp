using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiSanPham_ThemMoiSanPham : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    DataTable dtDM = new DataTable();
    DataTable dtNhom = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        dtDM = danhMucBUS.LayDanhSachDanhMuc();
        dtNhom = nhomSP_BUS.LayDanhSachNhomSP();

        if (!IsPostBack)
        {

            LayDanhMuc();
            LayNhom((int)dtDM.Rows[0]["maDM"]);
            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "chinh-sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";

            DataTable dt = new DataTable();
            dt = sanPhamBUS.LaySPById(id);
            if (dt.Rows.Count > 0)
            {
                ddlDanhMuc.SelectedValue = dt.Rows[0]["maDM"].ToString();
                tbTenSanPham.Text = dt.Rows[0]["tenSP"].ToString();
                tbGiaBan.Text = dt.Rows[0]["giaBan"].ToString();

                ddlNhom.SelectedValue = dt.Rows[0]["maNhomSP"].ToString();

                tbMoTa.Text = dt.Rows[0]["chiTiet"].ToString();

                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='../Images/" + dt.Rows[0]["anhSP"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["anhSP"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
        }

    }

    private void LayNhom(int idDM)
    {
        ddlNhom.Items.Clear();

        for (int i = 0; i < dtNhom.Rows.Count; i++)
        {
            if ((int)dtNhom.Rows[i]["maDM"] == idDM)
            ddlNhom.Items.Add(new ListItem(dtNhom.Rows[i]["tenNhomSP"].ToString(), dtNhom.Rows[i]["maNhomSP"].ToString()));
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

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "them-moi")
        {
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif") || flAnhDaiDien.FileName.EndsWith(".JPEG") || flAnhDaiDien.FileName.EndsWith(".JPG") || flAnhDaiDien.FileName.EndsWith(".PNG") || flAnhDaiDien.FileName.EndsWith(".GIF"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("../Images/") + flAnhDaiDien.FileName);

                    sanPhamBUS.ThemSP(tbTenSanPham.Text, float.Parse(tbGiaBan.Text), tbMoTa.Text, flAnhDaiDien.FileName, int.Parse(ddlNhom.SelectedValue),  int.Parse(ddlDanhMuc.SelectedValue));
                    ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo sản phẩm: " + tbTenSanPham.Text + "</div>";

                    ResetControl();
                }
            }
            else ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:red;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Phải thêm ảnh sản phẩm!</div>";
        }
        else
        {
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("../Images/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            sanPhamBUS.SuaSP(id, tbTenSanPham.Text, float.Parse(tbGiaBan.Text), tbMoTa.Text, tenAnhDaiDien, int.Parse(ddlNhom.SelectedValue), int.Parse(ddlDanhMuc.SelectedValue));
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã sửa sản phẩm: " + tbTenSanPham.Text + "</div>";
        }
    }

    private void ResetControl()
    {
        tbTenSanPham.Text = "";
        tbGiaBan.Text = "";
        Response.Redirect("Admin.aspx?module=san-pham&cat=qlsp");
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }

    protected void ddlDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
    {
        LayNhom((int)dtDM.Rows[ddlDanhMuc.SelectedIndex]["maDM"]);
    }
}