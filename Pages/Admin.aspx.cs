using System;

public partial class Pages_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            //Đã đăng nhập
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
            ltrTenDangNhap.Text = Session["TenDangNhap"].ToString();
    }

    protected void lbtDangXuat_Click(object sender, EventArgs e)
    {
        Session["DangNhap"] = null;
        Session["TenDangNhap"] = null;

        Response.Redirect("Login.aspx");
    }
}