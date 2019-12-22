using System;

public partial class Pages_Home : System.Web.UI.Page
{
    string type = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["type"] != null)
        {
            type = Request.QueryString["type"];
        }

        if (type == "")
        {
            plHome.Controls.Add(LoadControl("UCHome.ascx"));
        }
        else if (type == "detail")
        {
            plHome.Controls.Add(LoadControl("UCDetailSP.ascx"));
        }
        else if (type == "main" || type == "sub-main")
        {
            plHome.Controls.Add(LoadControl("UCDanhSachSP.ascx"));
        }
        else if (type == "cart")
        {
            plHome.Controls.Add(LoadControl("UCGioHang.ascx"));
        }
        else if (type == "search")
        {
            plHome.Controls.Add(LoadControl("UCSearch.ascx"));
        }
    }
}