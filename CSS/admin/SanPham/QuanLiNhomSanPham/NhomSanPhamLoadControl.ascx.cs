using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiNhomSanPham_NhomSanPhamLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            case "them-moi":
            case "chinh-sua":
                plLoadControl.Controls.Add(LoadControl("ThemMoiDanhSachNhomSanPham.ascx"));
                break;

            case "hien-thi":
                plLoadControl.Controls.Add(LoadControl("HienThiDanhSachNhomSanPham.ascx"));
                break;

            default:
                plLoadControl.Controls.Add(LoadControl("HienThiDanhSachNhomSanPham.ascx"));
                break;

        }
    }
}