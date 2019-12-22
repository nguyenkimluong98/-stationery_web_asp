using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        DataTable dt = QuanLi.DangNhap(tbTenDangNhap.Text, MaHoa.MaHoaMD5(tbMatKhau.Text));
        if (dt.Rows.Count > 0)
        {
            Session["DangNhap"] = "1";

            //Gán thêm thông tin tài khoản đã đăng nhập
            Session["TenDangNhap"] = dt.Rows[0]["hoTen"];
            Response.Redirect("Admin.aspx");
        }
        else
        {
            ltrThongBao.Text = "<div class='ThongBao'>Tên đăng nhập hoặc mật khẩu không chính xác!</div>";
        }

    }
}