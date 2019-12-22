using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiNhomSanPham_Ajax_NhomSanPham : System.Web.UI.Page
{
    string thaotac = "";
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    protected void Page_Load(object sender, EventArgs e)
    {
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
            case "XoaNhomSanPham":
                XoaNhomSanPham();
                break;

        }
    }

    private void XoaNhomSanPham()
    {
        string maNhom = "";
        string maDM = "";

        if (Request.Params["MaNhom"] != null && Request.Params["MaDM"] != null)
        {
            maNhom = Request.Params["MaNhom"];
            maDM = Request.Params["MaDM"];

            nhomSP_BUS.XoaNhomSP(maNhom, maDM);

            // Trả về thông báo 1 thực hiện thành công 2 thực hiện không thành công
            Response.Write("1");
        }
    }
}