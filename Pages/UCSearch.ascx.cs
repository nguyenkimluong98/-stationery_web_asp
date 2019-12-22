using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UCSearch : System.Web.UI.UserControl
{
    string submit = "";
    SanPhamBUS sanPhamBus = new SanPhamBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["submit"] != null)
        {
            submit = Request.QueryString["submit"];
            submit = submit.Replace('-', ' ');
            ltrTitle.Text = @"<h1 class='bar'>Kết quả tìm kiếm cho từ khóa ''" + submit + @"''</h1>";
        }

        if (submit != "")
        {
            SearchSanPham();
        }
    }

    void SearchSanPham()
    {
        DataTable dt = sanPhamBus.SearchSP(submit);

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrSanPham.Text += @"<li>
                    <div class='pic'>
                        <a href='Home.aspx?type=detail&id=" + dt.Rows[i]["maSP"].ToString() + @"'><img width='120' src='../Images/" + dt.Rows[i]["anhSP"].ToString() + @"' alt='" + dt.Rows[i]["tenSP"].ToString() + @"'></a>
                    </div>
                    <div class='cont'>
                        <div class=title'>
                            <a href='Home.aspx?type=detail&id=" + dt.Rows[i]["maSP"].ToString() + @"' title='" + dt.Rows[i]["tenSP"].ToString() + @"'>" + dt.Rows[i]["tenSP"].ToString() + @"</a>
                        </div>
                        <div class='price'>
                            " + dt.Rows[i]["giaBan"].ToString() + "đ" + @"
                        </div>
                        <div class='des'>" + dt.Rows[i]["chiTiet"].ToString()+ @"</div>
                    </div>
                    <div class='clear'></div>
                </li>";
            }
        }
        else
        {
            ltrTitle.Text = @"<li><h3>Không có sản phẩm nào phù hợp</h3></li>";
        }
    }
}