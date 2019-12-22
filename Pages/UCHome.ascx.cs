using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UCHome : System.Web.UI.UserControl
{
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayTopBanChay();
            LayDanhSachSP(1, lblBut, ltrBut);
            LayDanhSachSP(2, lblDungCu, ltrDungCu);
            LayDanhSachSP(7, lblTapHoa, ltrTapHoa);
            LayDanhSachSP(4, lblGiay, ltrGiay);
            LayDanhSachSP(6, lblSo, ltrSo);
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

    void LayDanhSachSP(int maDM, Label label, Literal literal)
    {
        DataTable dtBut = sanPhamBUS.LayDanhSach4SP(maDM);
        literal.Text = "";
        if (dtBut.Rows.Count > 0)
        {
            label.Text = @"<h3>"+ dtBut.Rows[0]["tenDM"].ToString() + @"</h3>";
            for (int i = 0; i < dtBut.Rows.Count; i++)
            {
                literal.Text += @"<div class='khungchuasp'>
                                    <div class='zoom'>
                                        <a href = 'Home.aspx?type=detail&id=" + dtBut.Rows[i]["maSP"].ToString() + @"'>
                                            <img class='thumbnail' src='../Images/" + dtBut.Rows[i]["anhSP"].ToString() + @"'>
                                        </a>  
                                    </div>
                                    <div class='tensp'><a href = '#' >" + dtBut.Rows[i]["tenSP"].ToString() + @"</a></div>
                                    <div class='giaban'>" + dtBut.Rows[i]["giaBan"].ToString() + "đ" + @"</div>
                                </div>";
            }
        }
    }
}