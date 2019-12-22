using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_DonHang_HienThiDonHang : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LayDonHang();
    }

    private void LayDonHang()
    {
        DataTable dt = DonHang.LayDanhSachDonHang();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            int maTinhTrang = int.Parse(dt.Rows[i]["tinhTrang"].ToString());
            string tinhTrang = "";
            switch(maTinhTrang)
            {
                case 0:
                    tinhTrang = "Chờ xác nhận";
                    break;
                case 1:
                    tinhTrang = "Đang giao hàng";
                    break;
                case 2:
                    tinhTrang = "Đã thanh toán";
                    break;
                case 3:
                    tinhTrang = "Đã hủy";
                    break;
                default:
                    tinhTrang = "Chờ xác nhận";
                    break;
            }

            ltrDonHang.Text += @"
                   <tr id='maDong_" + dt.Rows[i]["maDH"] + @"'>
                        <td class='cotMa'>" + dt.Rows[i]["maDH"] + @"</td>
                       <td class='cotHoTen'>" + dt.Rows[i]["hoTen"] + @"</td>
                       <td class='cotTenDK'>" + dt.Rows[i]["dienThoai"] + @"</td>
                       <td class='cotHoTen'>" + dt.Rows[i]["email"].ToString() + @"</td>
                        <td class='cotDiaChi'>" + dt.Rows[i]["diaChi"].ToString() + @"</td>
                        <td class='cotNgaySinh'>" + dt.Rows[i]["ngayLap"].ToString().Split(' ')[0] + @"</td>
                        <td class='cotHoTen'>" + tinhTrang + @"</td>
                       <td class='cotCongCu'>
                            <a href='Admin.aspx?module=don-dat-hang&thaotac=chi-tiet&id=" + dt.Rows[i]["maDH"] + @"' class='chiTiet' title='Xem chi tiết'></a>
                           <a href='Admin.aspx?module=don-dat-hang&thaotac=chinh-sua&id=" + dt.Rows[i]["maDH"] + @"' class='sua' title='Sửa'></a>
                           <a href=javascript:XoaDonHang('" + dt.Rows[i]["maDH"] + @"') class='xoa' title='Xóa'></a>
                       </td>
                   </tr>
            ";
        }

    }
}