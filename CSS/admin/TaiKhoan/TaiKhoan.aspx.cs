using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_TaiKhoan_Ajax_TaiKhoan : System.Web.UI.Page
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            if (Request.Params["ThaoTac"] != null)
            {
                thaotac = Request.Params["ThaoTac"];
            }

            switch (thaotac)
            {
                case "XoaTaiKhoan":
                    XoaTaiKhoan();
                    break;
            }
        }
    }

    private void XoaTaiKhoan()
    {
        string TenDangNhap = "";
        if (Request.Params["TenDangNhap"] != null)
        {
            TenDangNhap = Request.Params["TenDangNhap"];

            if (TenDangNhap.ToLower() != "admin")
            {
                int kq = QuanLi.XoaTaiKhoan(TenDangNhap);
                if (kq != -1)
                {
                    Response.Write("1");
                }
                else
                {
                    Response.Write("Có lỗi khi xóa!");
                }
            }
            else
            {
                Response.Write("Không được xóa tài khoản Admin");
            }
        }
    }
}