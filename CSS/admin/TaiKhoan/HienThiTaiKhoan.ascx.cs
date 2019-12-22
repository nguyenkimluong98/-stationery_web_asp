using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_TaiKhoan_HienThiTaiKhoan : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayTaiKhoan();
    }

    private void LayTaiKhoan()
    {
        DataTable dt = QuanLi.LayDanhSachTaiKhoan();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrTaiKhoan.Text += @"
       <tr id='maDong_" + dt.Rows[i]["taiKhoan"] + @"'>
           <td class='cotTenDK'>" + dt.Rows[i]["taiKhoan"] + @"</td>
           <td class='cotHoTen'>" + dt.Rows[i]["hoTen"] + @"</td>
           <td class='cotNgaySinh'>" + dt.Rows[i]["ngaySinh"].ToString().Split(' ')[0] + @"</td>
           <td class='cotCongCu'>
               <a href='Admin.aspx?module=tai-khoan&thaotac=chinh-sua&id=" + dt.Rows[i]["taiKhoan"] + @"' class='sua' title='Sửa'></a>
               <a href=javascript:XoaTaiKhoan('" + dt.Rows[i]["taiKhoan"] + @"') class='xoa' title='Xóa'></a>
           </td>
       </tr>
";
        }

    }
}