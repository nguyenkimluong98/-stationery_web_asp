using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_DonHang_ChinhSuaDonHang : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }

        if (!IsPostBack)
        {
            LoadDonHang();
        }
    }

    void LoadDonHang()
    {
        DataTable dt = DonHang.LayDonHangTheoID(id);
        if (dt.Rows.Count > 0)
        {
            dlTinhTrang.Items.Add(new ListItem("Chờ xác nhận", "0"));
            dlTinhTrang.Items.Add(new ListItem("Đang giao hàng", "1"));
            dlTinhTrang.Items.Add(new ListItem("Đã thanh toán", "2"));
            dlTinhTrang.Items.Add(new ListItem("Đã hủy", "3"));

            tbDiaChi.Text = dt.Rows[0]["diaChi"].ToString();
            tbMaDH.Text = dt.Rows[0]["maDH"].ToString();
            tbHoTen.Text = dt.Rows[0]["hoTen"].ToString();
            tbEmail.Text = dt.Rows[0]["email"].ToString();
            tbNgayDat.Text = dt.Rows[0]["ngayLap"].ToString().Split(' ')[0];
            tbSDT.Text = dt.Rows[0]["dienThoai"].ToString();

            dlTinhTrang.SelectedValue = dt.Rows[0]["tinhTrang"].ToString();
        }
    }

    protected void btChinhSua_Click(object sender, EventArgs e)
    {
        if (DonHang.CapNhatTinhTrangDonHang(id, dlTinhTrang.SelectedValue) > 0)
        {
            Response.Redirect("Admin.aspx?module=don-dat-hang");
        }
        else ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đơn hàng không tồn tại</div>";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx?module=don-dat-hang");
    }
}