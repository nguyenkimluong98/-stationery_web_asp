using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_TaiKhoan_ThemMoiTaiKhoan : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "chinh-sua")
        {
            btThemMoi.Text = "Chỉnh Sửa";
            tbTenDangNhap.Enabled = false;

            DataTable dt = new DataTable();
            dt = QuanLi.LayTaiKhoanTheoTen(id);
            if (dt.Rows.Count > 0)
            {
                tbTenDangNhap.Text = dt.Rows[0]["taiKhoan"].ToString();
                tbHoTen.Text = dt.Rows[0]["hoTen"].ToString();
                tbNgaySinh.Text = dt.Rows[0]["ngaySinh"].ToString().Split(' ')[0];

                //lưu lại mật khẩu cũ vào trường ẩn để lấy lại khi ko cập nhật mật khẩu mới
                hdMatKhauCu.Value = dt.Rows[0]["matKhau"].ToString();
                // bỏ yêu cầu bắt buộc nhập mật khẩu khi cập nhật
                RequiredFieldValidator2.Visible = false;
            }
        }

        else
        {
            btThemMoi.Text = "Thêm Mới";
        }

    }

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "them-moi")
        {
            string matKhau = "";
            if (matKhau != null)
                matKhau = MaHoa.MaHoaMD5(tbMatKhau.Text);
            else
                matKhau = MaHoa.MaHoaMD5(hdMatKhauCu.Value);//TRƯỜNG hợp ko nhập mật khẩu thì lấy lại mật khẩu cũ

            int kq = QuanLi.ThemMoiTaiKhoan(tbHoTen.Text, tbNgaySinh.Text, tbTenDangNhap.Text, matKhau);
            if (kq != -1)
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo tài khoản: " + tbTenDangNhap.Text + "</div>";

                Response.Redirect("Admin.aspx?module=tai-khoan");
            }
            else
            {
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Tài khoản đã tồn tại!</div>";
            }
        }
        else
        {
            string matKhau = MaHoa.MaHoaMD5(tbMatKhau.Text);

            int kq = QuanLi.ChinhSuaTaiKhoan(
                id, tbHoTen.Text, tbNgaySinh.Text,
                matKhau);

            if (kq > 0)
            {
                Response.Redirect("Admin.aspx?module=tai-khoan");
            }
            else ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:red;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Lỗi khi chỉnh sửa: " + tbTenDangNhap.Text + "</div>";
        }
    }

    private void ResetControl()
    {
        tbTenDangNhap.Text = "";
        tbMatKhau.Text = "";
        tbHoTen.Text = "";
        tbNgaySinh.Text = "";
        Response.Redirect("Admin.aspx?module=tai-khoan");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}