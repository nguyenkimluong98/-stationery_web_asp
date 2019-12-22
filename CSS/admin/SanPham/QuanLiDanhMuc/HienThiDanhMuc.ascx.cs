using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiDanhMuc_HienThiDanhMuc : System.Web.UI.UserControl
{
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayDanhMuc();
    }

    private void LayDanhMuc()
    {
        DataTable dt = new DataTable();
        dt = danhMucBUS.LayDanhSachDanhMuc();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhMuc.Text += @"
                <tr id='maDong_" + dt.Rows[i]["maDM"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["maDM"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["tenDM"] + @"</td>
                    <td class='cotCongCu'>
                        <a href='Admin.aspx?module=san-pham&cat=qldm&thaotac=chinh-sua&id=" + dt.Rows[i]["maDM"] + @"' class='sua' title='Sửa'></a>
                        <a href='javascript:XoaDanhMuc(" + dt.Rows[i]["maDM"] + @")' class='xoa' title='Xóa'></a>
                    </td>
                </tr>
            ";
        }

    }
}