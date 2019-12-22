using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiNhomSanPham_HienThiDanhSachNhomSanPham : System.Web.UI.UserControl
{
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    DataTable dtDM = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dtDM = danhMucBUS.LayDanhSachDanhMuc();
        if (!IsPostBack)
        {
            LayDanhMuc();
            LayNhomSanPham(true);
        }
    }

    private void LayDanhMuc()
    {
        ddlDanhMucCha.Items.Clear();
        ddlDanhMucCha.Items.Add(new ListItem("Tất cả", "tatca"));
        for (int i = 0; i < dtDM.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dtDM.Rows[i]["tenDM"].ToString(), dtDM.Rows[i]["maDM"].ToString()));
        }
    }

    private void LayNhomSanPham(bool layAll)
    {
        DataTable dt = new DataTable();
        NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
        dt = nhomSP_BUS.LayDanhSachNhomSP();
        ltrNhomSanPham.Text = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (layAll)
            {
                ltrNhomSanPham.Text += @"
                <tr id='maDong_" + (int.Parse(dt.Rows[i]["maNhomSP"].ToString()) + "_" + int.Parse(dt.Rows[i]["maDM"].ToString())) + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["maNhomSP"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["tenNhomSP"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["tenDM"] + @"</td>
                    <td class='cotCongCu'>
                        <a href='Admin.aspx?module=san-pham&cat=qlnsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maNhomSP"] + @"&madm=" + dt.Rows[i]["maDM"] + @"' class='sua' title='Sửa'></a>
                        <a href='javascript:XoaNhomSanPham(" + dt.Rows[i]["maNhomSP"] + @", " + dt.Rows[i]["maDM"] + @")' class='xoa' title='Xóa'></a>
                    </td>
                </tr>
                ";
            }
            else
            {
                if (int.Parse(dt.Rows[i]["maDM"].ToString()) == int.Parse(ddlDanhMucCha.SelectedValue))
                {
                    ltrNhomSanPham.Text += @"
                    <tr id='maDong_" + (int.Parse(dt.Rows[i]["maNhomSP"].ToString()) + "_" + int.Parse(dt.Rows[i]["maDM"].ToString())) + @"'>
                        <td class='cotMa'>" + dt.Rows[i]["maNhomSP"] + @"</td>
                        <td class='cotTen'>" + dt.Rows[i]["tenNhomSP"] + @"</td>
                        <td class='cotTen'>" + dt.Rows[i]["tenDM"] + @"</td>
                        <td class='cotCongCu'>
                            <a href='Admin.aspx?module=san-pham&cat=qlnsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maNhomSP"] + @"&madm=" + dt.Rows[i]["maDM"] + @"' class='sua' title='Sửa'></a>
                            <a href='javascript:XoaNhomSanPham(" + dt.Rows[i]["maNhomSP"] + @", " + dt.Rows[i]["maDM"] + @")' class='xoa' title='Xóa'></a>
                        </td>
                    </tr>
                ";
                }
            }
        }

    }

    protected void ddlDanhMucCha_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDanhMucCha.SelectedValue == "tatca")
        {
            LayNhomSanPham(true);
        }
        else LayNhomSanPham(false);
    }
}