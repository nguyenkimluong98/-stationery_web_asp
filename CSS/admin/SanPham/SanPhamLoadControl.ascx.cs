using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_SanPhamLoadControl : System.Web.UI.UserControl
{
    string cat = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["cat"] != null)
        {
            cat = Request.QueryString["cat"];
        }

        switch (cat)
        {
            case "qldm":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLiDanhMuc/DanhMucLoadControl.ascx"));
                break;
            case "qlnsp":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLiNhomSanPham/NhomSanPhamLoadControl.ascx"));
                break;
            case "qlsp":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLiSanPham/QLSanPhamLoadControl.ascx"));
                break;
            default:
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLiDanhMuc/DanhMucLoadControl.ascx"));
                break;
        }
    }
}