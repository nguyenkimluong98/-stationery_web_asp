using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiDanhMuc_Ajax_DanhMuc : System.Web.UI.Page
{
    string thaotac = "";
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        //{
        //    //Đã đăng nhập
        //}
        //else
        //{
        //    return;
        //}

        if (Request.Params["ThaoTac"] != null)
        {
            thaotac = Request.Params["ThaoTac"];
        }

        switch (thaotac)
        {
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;

        }
    }

    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null)
        {
            MaDM = Request.Params["MaDM"];

            danhMucBUS.XoaDanhMuc(MaDM);

            Response.Write("1");
        }
    }
}