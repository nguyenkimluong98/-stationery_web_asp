using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiSanPham_Ajax_SanPham : System.Web.UI.Page
{
    string thaotac = "";
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Code kiểm tra đăng nhập tại đây sau đó mới thực hiện các thao tác dưới
        //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
        //if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        //{
        //    //Đã đăng nhập
        //}
        //else
        //{
        //    //Nếu chưa đăng nhập --> return để dừng không cho thực hiện các câu lệnh bên dưới
        //    return;
        //}
        if (Request.Params["ThaoTac"] != null)
        {
            thaotac = Request.Params["ThaoTac"];
        }

        switch (thaotac)
        {
            case "XoaSanPham":
                XoaSanPham();
                break;

        }
    }

    private void XoaSanPham()
    {
        string MaSP = "";
        if (Request.Params["MaSP"] != null)
        {
            MaSP = Request.Params["MaSP"];

            sanPhamBUS.XoaSP(MaSP);

            Response.Write("1");
        }
    }
}