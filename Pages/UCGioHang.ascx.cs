using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_UCGioHang : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnDatHang_Click(object sender, EventArgs e)
    {
        DataTable dtGioHang = (DataTable)Session["GioHang"];
        if (dtGioHang != null && dtGioHang.Rows.Count > 0)
        {
            string hoTen = tbHoTen.Text.Trim();
            string sdt = tbSDT.Text.Trim();
            string email = tbEmail.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();

            int maDonHangNew = DonHang.ThemDonHang(hoTen, sdt, email, diaChi);

            if (maDonHangNew != -1)
            {
                for (int i = 0; i < dtGioHang.Rows.Count; i++)
                {
                    int soLuong = int.Parse(dtGioHang.Rows[i]["soLuong"].ToString());
                    int maSP = int.Parse(dtGioHang.Rows[i]["maSP"].ToString());
                    ChiTietDH.ThemChiTietDH(soLuong, maSP, maDonHangNew);
                }

                Session["GioHang"] = null;
                ltrThongBao.Text = @"<h5 style='color: blue;'>Đặt hàng thành công! Chúng tôi sẽ liên lạc với bạn sớm nhất có thể.</h3>";
            }
            else
            {
                ltrThongBao.Text = @"<h5 style='color: red;'>Tạo đơn hàng thất bại.</h3>";
            }
        }
        else
        {
            ltrThongBao.Text = @"<h5 style='color: red;'>Không có sản phẩm nào trong giỏ hàng.</h3>";
        }
    }
}