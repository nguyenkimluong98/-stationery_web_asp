using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UCDetailSP : System.Web.UI.UserControl
{
    string maSP = "";
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            maSP = Request.QueryString["id"];
        }

        if (!IsPostBack)
        {
            LayThongTinSanPham();
            LayTopBanChay();
        }
    }

    void LayThongTinSanPham()
    {
        DataTable dtSP = sanPhamBUS.LaySPById(maSP);
        if (dtSP.Rows.Count > 0)
        {
            ltrBigImg.Text = @"<img src='../Images/"+ dtSP.Rows[0]["anhSP"] + @"' class='thumb_goc' style='opacity: 1;'/>";
            ltrSmallImg.Text = @"<img src='../Images/" + dtSP.Rows[0]["anhSP"] + @"'>";
            ltrZoomUp.Text = @"<img src='../Images/" + dtSP.Rows[0]["anhSP"] + @"' style='position: absolute; display: block; left: 0px; top: 0px;'>";
            ltrZoomWin.Text = @"<img src='../Images/" + dtSP.Rows[0]["anhSP"] + @"' style='position: absolute; border: 0px; display: block; left: 0px; top: 0px;width: 450px;height: 450px;'>";
            ltrTitle.Text = @"<h1>" + dtSP.Rows[0]["tenSP"] + @"</h1>";
            ltrMa.Text = "SP" + dtSP.Rows[0]["maSP"];
            ltrGia.Text = dtSP.Rows[0]["giaBan"] + "đ";
            ltrMota.Text = dtSP.Rows[0]["chiTiet"].ToString();
            LaySanPhamCungNhom(dtSP.Rows[0]["maNhomSP"].ToString(), dtSP.Rows[0]["maDM"].ToString(),dtSP.Rows[0]["maSP"].ToString());
        }
    }

    void LayTopBanChay()
    {
        DataTable dtTop = sanPhamBUS.LayTopSanPham();

        ltrTop.Text = "";
        for (int i = 0; i < dtTop.Rows.Count; i++)
        {
            ltrTop.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtTop.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtTop.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = 'Home.aspx?type=detail&id=" + dtTop.Rows[i]["maSP"].ToString() + @"' >" + dtTop.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtTop.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
        }

        int numOfMissing = 8 - dtTop.Rows.Count;

        if (numOfMissing > 0)
        {
            DataTable dtRandom = sanPhamBUS.LayDanhSachRandom(numOfMissing);
            for (int i = 0; i < dtRandom.Rows.Count; i++)
            {
                ltrTop.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtRandom.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtRandom.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = 'Home.aspx?type=detail&id=" + dtRandom.Rows[i]["maSP"].ToString() + @"' >" + dtRandom.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtRandom.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
            }
        }
    }

    void LaySanPhamCungNhom(string maNhomSP, string maDM, string idCu)
    {
        DataTable dtSame = sanPhamBUS.LaySPCungLoai(maNhomSP, maDM, idCu);

        ltrSameSP.Text = "";
        for (int i = 0; i < dtSame.Rows.Count; i++)
        {
            ltrSameSP.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtSame.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtSame.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = 'Home.aspx?type=detail&id=" + dtSame.Rows[i]["maSP"].ToString() + @"' >" + dtSame.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtSame.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
        }
    }

    private void ThemVaoGioHang()
    {
        string ketQua = "";

        DataTable dt = new DataTable();
        dt = sanPhamBUS.LaySPById(maSP);
        if (dt.Rows.Count > 0)
        {

            if (Session["GioHang"] == null)
            {
                DataTable dtGioHang = new DataTable();
                dtGioHang.Columns.Add("maSP");
                dtGioHang.Columns.Add("tenSP");
                dtGioHang.Columns.Add("anhSP");
                dtGioHang.Columns.Add("giaBan");
                dtGioHang.Columns.Add("soLuong");

                dtGioHang.Rows.Add(dt.Rows[0]["maSP"].ToString(), dt.Rows[0]["tenSP"].ToString(),
                    dt.Rows[0]["anhSP"].ToString(), dt.Rows[0]["giaBan"].ToString(), 1);

                Session["GioHang"] = dtGioHang;

            }
            else
            {
                DataTable dtGioHang = new DataTable();
                dtGioHang = (DataTable)Session["GioHang"];

                int viTriSPTrongGioHang = -1;
                for (int i = 0; i < dtGioHang.Rows.Count; i++)
                {
                    if (dtGioHang.Rows[i]["maSP"].ToString() == maSP)
                    {
                        viTriSPTrongGioHang = i;
                        break;
                    }
                }

                if (viTriSPTrongGioHang != -1)
                {
                    int soLuongHienTai = int.Parse(dtGioHang.Rows[viTriSPTrongGioHang]["soLuong"].ToString());

                    soLuongHienTai += 1;

                    dtGioHang.Rows[viTriSPTrongGioHang]["soLuong"] = soLuongHienTai;

                    Session["GioHang"] = dtGioHang;
                }
                else
                {
                    dtGioHang.Rows.Add(dt.Rows[0]["maSP"].ToString(), dt.Rows[0]["tenSP"].ToString(),
                        dt.Rows[0]["anhSP"].ToString(), dt.Rows[0]["giaBan"].ToString(), 1);

                    Session["GioHang"] = dtGioHang;
                }

                
            }
            ltrThongBao.Text = @"<h4 style='color: red;'>Đã thêm 1 sản phẩm vào giỏ hàng</h4>";
        }
        else
        {
            ketQua = "Không tồn tại sản phẩm này";
        }
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        ThemVaoGioHang();
    }

    protected void btnMuaNgay_Click(object sender, EventArgs e)
    {
        ThemVaoGioHang();
        Response.Redirect("Home.aspx?type=cart");
    }
}