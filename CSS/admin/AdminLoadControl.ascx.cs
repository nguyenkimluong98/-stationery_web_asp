using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_AdminLoadControl : System.Web.UI.UserControl
{
    string module = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["module"] != null)
        {
            module = Request.QueryString["module"];
        }

        switch(module)
        {
            case "san-pham":
                plAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
            case "tai-khoan":
                plAdminLoadControl.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                break;
            case "don-dat-hang":
                plAdminLoadControl.Controls.Add(LoadControl("DonHang/DonHangLoadControl.ascx"));
                break;
            default:
                plAdminLoadControl.Controls.Add(LoadControl("UCThongKe.ascx"));
                break;
        }
        
    }
}