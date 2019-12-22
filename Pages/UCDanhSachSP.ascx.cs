using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UCDanhSachSP : System.Web.UI.UserControl
{
    string type = "";
    string nhom = "";
    string dm = "";
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["type"] != null)
        {
            type = Request.QueryString["type"];
        }

        if (Request.QueryString["nhom"] != null)
        {
            nhom = Request.QueryString["nhom"];
        }

        if (Request.QueryString["dm"] != null)
        {
            dm = Request.QueryString["dm"];
        }

        
        if (!IsPostBack)
        {
            if (type == "main")
            {
                GetAllSPTheoDM();
            }
            else if (type == "sub-main")
            {
                GetAllSPThemNhom();
            }
        }
    }

    void GetAllSPTheoDM()
    {
        ltrSanPham.Text = "";
        DataTable dtDM = danhMucBUS.LayDanhMucById(dm);
        if (dtDM.Rows.Count > 0)
        {
            ltrTitle.Text = @"<div style='float: right; font-size: 18px; color: #217fbc; padding: 10px 10px 10px;'>" + dtDM.Rows[0]["tenDM"].ToString() + @"</div>";
            DataTable dtSP = sanPhamBUS.LayDanhSachTheoDM(dm);
            for (int i = 0; i < dtSP.Rows.Count; i++)
            {
                ltrSanPham.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtSP.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtSP.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = 'Home.aspx?type=detail&id=" + dtSP.Rows[i]["maSP"].ToString() + @"' >" + dtSP.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtSP.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
            }
        }
    }

    void GetAllSPThemNhom()
    {
        ltrSanPham.Text = "";
        DataTable dtNhom = nhomSP_BUS.LayNhomSPByTen(nhom, dm);
        if (dtNhom.Rows.Count > 0)
        {
            ltrTitle.Text = @"<div style='float: right; font-size: 18px; color: #217fbc; padding: 10px 10px 10px;'>" + dtNhom.Rows[0]["tenNhomSP"].ToString() + @"</div>";
            DataTable dtSP = sanPhamBUS.LayDanhSachTheoNhom(nhom, dm);
            for (int i = 0; i < dtSP.Rows.Count; i++)
            {
                ltrSanPham.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtSP.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtSP.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = 'Home.aspx?type=detail&id=" + dtSP.Rows[i]["maSP"].ToString() + @"' >" + dtSP.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtSP.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
            }
        }
    }
}