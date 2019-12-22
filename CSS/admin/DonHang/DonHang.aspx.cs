using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_DonHang_DonHang : System.Web.UI.Page
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
                case "XoaDonHang":
                    XoaDonHang();
                    break;
            }
        }
    }

    void XoaDonHang()
    {
        string maDH = "";
        if (Request.Params["MaDH"] != null)
        {
            maDH = Request.Params["MaDH"];
            if (DonHang.XoaDonHang(maDH) > 0)
            {
                Response.Write("1");
            }
            else
            {
                Response.Write("Có lỗi khi xóa!");
            }
        }
    }
}