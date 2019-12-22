using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_TaiKhoan_TaiKhoanLoadControl : System.Web.UI.UserControl
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
                plLoadControl.Controls.Add(LoadControl("ThemMoiTaiKhoan.ascx"));
                break;

            case "hien-thi":
                plLoadControl.Controls.Add(LoadControl("HienThiTaiKhoan.ascx"));
                break;

            default:
                plLoadControl.Controls.Add(LoadControl("HienThiTaiKhoan.ascx"));
                break;
        }
    }
}