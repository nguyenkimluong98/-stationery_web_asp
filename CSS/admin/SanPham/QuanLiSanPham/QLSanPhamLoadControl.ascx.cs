using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiSanPham_SanPhamLoadControl : System.Web.UI.UserControl
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
                plLoadControl.Controls.Add(LoadControl("ThemMoiSanPham.ascx"));
                break;

            case "hien-thi":
                plLoadControl.Controls.Add(LoadControl("HienThiDanhSachSanPham.ascx"));
                break;

            default:
                plLoadControl.Controls.Add(LoadControl("HienThiDanhSachSanPham.ascx"));
                break;

        }
    }
}