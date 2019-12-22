using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_DonHang_DonHangLoadControl : System.Web.UI.UserControl
{
    string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }

        switch (thaotac)
        {
            case "hien-thi":
                plLoadControl.Controls.Add(LoadControl("HienThiDonHang.ascx"));
                break;
            case "chi-tiet":
                plLoadControl.Controls.Add(LoadControl("ChiTietDonHang.ascx"));
                break;
            case "chinh-sua":
                plLoadControl.Controls.Add(LoadControl("ChinhSuaDonHang.ascx"));
                break;
            default:
                plLoadControl.Controls.Add(LoadControl("HienThiDonHang.ascx"));
                break;
        }
    }
}